using System;
class Human : Character
{
    private int _charisma = 100;
    public int Charisma { get; }

    public string Race = "Human";

    public Human(string name) : base(name)
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