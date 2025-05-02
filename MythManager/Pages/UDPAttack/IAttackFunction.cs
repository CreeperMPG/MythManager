namespace MythManager.Pages.UDPAttack
{
    // Token: 0x02000014 RID: 20
    public interface IAttackFunction
    {
        // Token: 0x17000004 RID: 4
        // (get) Token: 0x0600004A RID: 74
        string Nickname { get; }

        // Token: 0x0600004B RID: 75
        AttackPacket ConstructPacket(ref string message);
    }
}
