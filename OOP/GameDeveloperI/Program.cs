Attack TwoInchPunch = new("Two inch punch", 15);
Attack RoundhouseKick = new("Roundhouse kick", 25);
Attack MoesEyePoke = new("MoesEyePoke", 1);
Enemy Ninja = new("shredder", new List<Attack>());
Ninja.AddAttack(TwoInchPunch);
Ninja.AddAttack(RoundhouseKick);
Ninja.AddAttack(MoesEyePoke);

Console.WriteLine(Ninja.RandomAttack().Name);