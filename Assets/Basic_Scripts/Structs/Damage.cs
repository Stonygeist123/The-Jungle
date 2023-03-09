public readonly struct Damage
{
    public Damage(int id, float dmg)
    {
        ID = id;
        Dmg = dmg;
    }

    public int ID { get; }
    public float Dmg { get; }
}