class Enemy
{
    public string Name;
    protected int _Health;
    public int Health
    {
        get{return _Health;}
    }
    public List<Attack> AttackList;

    public Enemy(string name, List<Attack> attackList)
    { 
        Name = name;
        _Health = 100;
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
}