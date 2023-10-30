class MagicCaster : Enemy
{
    public MagicCaster() : base("Magic Caster", new List<Attack>(), 80) {
        Attack FireBall = new("Fireball", 25);
        Attack LightningBolt = new("Lightning Bolt", 20);
        Attack StaffStrike = new("Staff Strike", 20);
        AddAttack(FireBall);
        AddAttack(LightningBolt);
        AddAttack(StaffStrike);
    }
    public void Heal(Enemy Target)
    {
        Target.Health += 40;
        Console.WriteLine($"{Target.Name} health has been increased by 40 to {Target.Health}");
    }
}