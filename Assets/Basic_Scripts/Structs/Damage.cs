public readonly struct Damage
{
    public Damage(int id, uint dmg)
    {
        ID = id;
        Dmg = dmg;
    }

    public int ID { get; }
    public uint Dmg { get; }
}