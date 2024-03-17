using BattleRoyale.Models;



Console.WriteLine("Battle Royale");

Fighter Kratos = new Fighter("Kratos", 13);
Knight Aragorn = new Knight("Aragorn", 4);
Sorcerer Dumbledore = new Sorcerer(7);
Beast Warwick = new Beast(6);

Enemy[] combatants = new Enemy[]
{
    Warwick,
    Kratos,
    Dumbledore,
    Aragorn,

};

int CombatantsAlive = 0;
while (CombatantsAlive != 1)
{
    CombatantsAlive = 0;
    for (int i = 0; i < combatants.Length; i++)
    {
        Enemy oponent = combatants[i].PickOpponent(combatants);

        if (combatants[i].IsAlive && combatants[i].IsParalyzed == false)
        {
            combatants[i].Attack(oponent);
            Console.WriteLine("Attacked: " + combatants[i] + " on: " + oponent + " with power: " + combatants[i].Damage);
        }
    }
    Console.WriteLine("Alive: " + CombatantsAlive);
    Console.WriteLine(Kratos);
    Console.WriteLine(Aragorn);
    Console.WriteLine(Dumbledore);
    Console.WriteLine(Warwick);
    for (int i = 0; i < combatants.Length; i++)
    {
        if (combatants[i].IsAlive) { CombatantsAlive++; }
        combatants[i].RemoveParalyzed();
    }

    
} 

for (int i = 0; i < combatants.Length; i++)
{
    if (combatants[i].IsAlive) { Console.WriteLine("Won: " + combatants[i]); }
}

