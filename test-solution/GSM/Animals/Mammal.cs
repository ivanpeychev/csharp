using System;

namespace Jungle
{
	public abstract class Mammal : Animal, IMammal
	{
		public Mammal(string name, int weight, char gender) : base(name, weight) 
		{
			this.Breastfeeds = true;
			this.IsLiveBorn = true;
			this.Gender = gender;
		}

		public int NumberOfLegs { get; protected set; }
		public char Gender { get; protected set; }

		public override void Eat(Food food)
		{
			if (food.Energy > 20)
			{
				this.IsDead = true;
				Console.WriteLine($"{this.Name} just died due to food poisoning from the {food.Name}");
			}
			else
			{
				this.Health += food.Energy;
				Console.WriteLine($"{this.Name} just ate {Tools.GetDeterminer(food.Name)} {food.Name} and " +
					$"{Tools.GetPronoun(this.Gender)} gained {food.Energy} health points");
			}
			Console.WriteLine();
		}
		public void Drink()
		{
			Console.WriteLine($"{this.Name} just drank water");
		}
	}
}
