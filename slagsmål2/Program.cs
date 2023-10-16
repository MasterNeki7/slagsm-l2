List<Fighter> fighters = new();
fighters.Add(new Tagilla());
fighters.Add(new Fighter());
fighters.Add(new Fighter());
fighters.Add(new Fighter());

Fighter Player = new Fighter();
Console.WriteLine("name your fighter!");

Player.name = Console.ReadLine();
Console.WriteLine("Choose your fighter!");
foreach (Fighter f in fighters)
{
    Console.WriteLine(f.name);
}



Console.ReadLine();
