using System.Collections.Generic;

namespace MythManager.Pages.UDPAttack
{
    public class AttackPacket
    {
        public List<byte[]> AttackPackets;
        public int TargetPort;
        public int IntervalMiliseconds;
        public AttackPacket(List<byte[]> attackPackets, int targetPort = 4705, int intervalMiliseconds = 0)
        {
            AttackPackets = attackPackets;
            TargetPort = targetPort;
            IntervalMiliseconds = intervalMiliseconds;
        }
    }
}
