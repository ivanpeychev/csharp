using System;
abstract class Character
{
    // Props
    public string Name { get; set; }

    private int _health = 100;
    public int Health
    {
        get { return _health; }
        set
        {
            _health = value;

            if (_health <= 0 && IsDead == false)
            {
                _health = 0;
                IsDead = true;
                Die();
            }
            else if (_health >= 100)
            {
                _health = 100;
                this.SingASong();
            }
        }
    }

    public bool IsDead = false;

    public Weapon Weapon { get; set; } = new Weapon();
    public Shield Shield { get; set; } = new Shield();

    public Character(string name) => Name = name;

    // Methods
    private void Die()
    {
        Console.WriteLine("The character {0} just died. OMG!", this.Name);
        Console.WriteLine();
    }

    private void SingASong()
    {
        Console.WriteLine($"{this.Name}: La-la-la-la!");
    }

    public void Ouch(Character character)
    {
        if (!character.IsDead)
        {
            Console.WriteLine("{0} says OUCH!", character.Name);
            Console.WriteLine();
        }
    }

    public void Attack(Character attacked)
    {
        if (attacked.IsDead == false)
        {
            Console.WriteLine("{0} attacked {1}", this.Name, attacked.Name);
        }
        else
        {
            Console.WriteLine("{0} attacked {1}'s corpse! Yuck!", this.Name, attacked.Name);
            Console.WriteLine();
        }

        attacked.Health -= (this.Weapon.AttackPower - attacked.Shield.DefencePoints);

        Ouch(attacked);
    }
}