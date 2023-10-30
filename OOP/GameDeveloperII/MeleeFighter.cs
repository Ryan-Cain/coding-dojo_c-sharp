class MeleeFighter : Enemy
{
    public MeleeFighter() : base("Melee Fighter", new List<Attack>(), 120) {
        Attack Punch = new("Punch", 20);
        Attack Kick = new("Kick", 15);
        Attack Tackle = new("Tackle", 25);
        AddAttack(Punch);
        AddAttack(Kick);
        AddAttack(Tackle);
    }
    public void Rage(Enemy Target)
    {
        PerformAttack(Target, RandomAttack());
        Target.Health -= 10;
    }
}