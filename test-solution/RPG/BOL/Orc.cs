using System;

class Orc : Character
{
    private string _color;
    public string Color { get; set; }

    public string Race = "Orc";

    public Orc(string name) : base(name)
    {
        base.Name = name;
    }

    public void PrintStats()
    {
        Console.WriteLine("Character");
        Console.WriteLine("Name: {0}", Name);
        Console.WriteLine("Race: {0}", Race);
        Console.WriteLine("Health: {0}", Health);
        Console.WriteLine("Weapon: {0}", Weapon.Name);
        Console.WriteLine("Shield: {0}", Shield.Name);
        Console.WriteLine();
    }
}