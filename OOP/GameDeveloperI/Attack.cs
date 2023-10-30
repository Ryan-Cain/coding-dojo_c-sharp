class Attack
{
    public string Name;
    public int Damage;

    public Attack(string name, int damage)
    {
        Name = name;
        Damage = damage;
        Console.WriteLine(this.Name);
        Console.WriteLine(this.Damage);
    }


}

