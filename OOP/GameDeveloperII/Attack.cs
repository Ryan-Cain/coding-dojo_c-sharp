class Attack
{
    public string Name;
    public int DamageAmount;

    public Attack(string name, int damageAmount)
    {
        Name = name;
        DamageAmount = damageAmount;
        Console.WriteLine(this.Name);
        Console.WriteLine(this.DamageAmount);
    }


}

