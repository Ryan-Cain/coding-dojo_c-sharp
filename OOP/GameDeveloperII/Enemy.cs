class Enemy
{
    public string Name;
    protected int _Health;
    public int Health
    {
        get{return _Health;}
        set{_Health = value;}
    }
    public List<Attack> AttackList;

    public Enemy(string name, List<Attack> attackList, int health=100)
    { 
        Name = name;
        _Health = health;
        AttackList = attackList;
        Console.WriteLine(this.Name);
        Console.WriteLine(AttackList);
    }
    public Attack RandomAttack()
    {
        Random rand = new Random();
            return AttackList[rand.Next(0,AttackList.Count)];
    }
    public void AddAttack(Attack attack)
    {
        AttackList.Add(attack);
    }
    public virtual void PerformAttack(Enemy Target, Attack ChosenAttack)
    {
        Target.Health -= ChosenAttack.DamageAmount;
        Console.WriteLine($"{Name} attacks {Target.Name} with {ChosenAttack.Name}, dealing {ChosenAttack.DamageAmount} damage and reducing {Target.Name}'s health to {Target.Health}!!");
    }

}