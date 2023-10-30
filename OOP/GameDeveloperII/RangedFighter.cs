class RangedFighter : Enemy
{
    public int Distance;
    public RangedFighter() : base("Ranged Fighter", new List<Attack>(), 120) {
        Distance = 5;
        Attack ShootAnArrow = new("Shoot An Arrow", 20);
        Attack ThrowAKnife = new("Throw A Knife", 15);
        AttackList.Add(ShootAnArrow);
        AttackList.Add(ThrowAKnife);
    }
    public override void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        if (Distance >= 10) {
            base.PerformAttack(Target, ChosenAttack);
        }
    }
    public void Rage(Enemy Target)
    {
        PerformAttack(Target, RandomAttack());
        Target.Health -= 10;
    }
    public void Dash()
    {
        Distance = 20;
    }

}