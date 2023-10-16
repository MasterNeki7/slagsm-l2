    List<Enemy> enemies = new();

    Random generator = new Random();

    for (int i = 0; i < 1; i++)
    {
        if (generator.Next(4) == 3 && enemies.Count(enemy => enemy.name == "Tagilla") == 0)
        {
            enemies.Add(new Tagilla());
        }
        else
        {
            enemies.Add(new Enemy());
        }
    }

    Enemy Player = new Enemy();
    Console.WriteLine("name your fighter!");
    Player.name = Console.ReadLine();


    Console.Clear();
    Console.WriteLine($"{Player.name} will be fighting:");

    foreach (Enemy e in enemies)
    {
        Console.WriteLine(e.name);
    }



Console.ReadLine();
