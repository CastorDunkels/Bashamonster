using System.Security.Cryptography;
using System;

Guy G1 = new();
Dude D1 = new();
Random Generator = new Random();

Console.WriteLine("Choose a name");
G1.Name = Console.ReadLine();
if (G1.Name == "")
{
    G1.Name = "Jerma";
}

while (D1.Hp >= 1)
{
    Console.Clear();
    Console.WriteLine($"Enemy:{D1.Name}");
    Console.WriteLine($"Health:{D1.Hp}");
    Console.WriteLine("\n");
    Console.WriteLine("Write ATTACK to deal dmg");

    string Attack = Console.ReadLine();
    Attack = Attack.ToLower();
    Console.Clear();

    if (Attack == "attack")
    {
        G1.AttackDmg = Generator.Next(10001);
        D1.Hp -= G1.AttackDmg;
        Console.WriteLine($"Enemy:{D1.Name}");
        Console.WriteLine($"Health:{D1.Hp}");
        Console.WriteLine("\n");
        Console.WriteLine($"{G1.Name} dealt {G1.AttackDmg} damage");
        if (D1.Hp < 0)
        {
            Console.Clear();
            D1.Hp = 0;
            Console.WriteLine($"Enemy:{D1.Name}");
            Console.WriteLine($"Health:{D1.Hp}");
            Console.WriteLine("\n");
            Console.WriteLine($"{G1.Name} dealt {G1.AttackDmg} damage");
            Console.WriteLine($"{D1.Name} Dies");
        }
    }
    else
    {
        Console.WriteLine($"Enemy:{D1.Name}");
        Console.WriteLine($"Health:{D1.Hp}");
        Console.WriteLine("\n");
        Console.WriteLine("Wrong");
    }

    Console.ReadKey();
}
