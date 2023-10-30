RangedFighter Legolas = new();
MeleeFighter BruceLee = new();
MagicCaster DrStrange = new();

BruceLee.PerformAttack(Legolas, BruceLee.AttackList[1]);
BruceLee.Rage(DrStrange);
Legolas.PerformAttack(BruceLee, Legolas.AttackList[0]);
Legolas.Dash();
Legolas.PerformAttack(BruceLee, Legolas.AttackList[0]);
DrStrange.PerformAttack(BruceLee, DrStrange.AttackList[0]);
DrStrange.Heal(Legolas);
DrStrange.Heal(DrStrange);