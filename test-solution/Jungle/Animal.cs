using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	public abstract class Animal : ICreature
	{
		public string Name { get; protected set; }
		public string Species { get; protected set; }
		public int Weight { get; protected set; }
		public bool IsLiveBorn { get; protected set; }
		public bool Breastfeeds { get; protected set; }
		public int Health { get; protected set; }
		public bool IsDead { get; protected set; }

		public Animal(string name, int weight)
		{
			Name = name;
			Weight = weight;
		}

		public void GetInfo()
		{
			Console.WriteLine("-------------------------------");
			Console.WriteLine("Name: {0}", this.Name);
			Console.WriteLine("Species: {0}", this.Species);
			Console.WriteLine("Weight: {0}", this.Weight);
			Console.WriteLine("IsLiveBorn: {0}", this.IsLiveBorn);
			Console.WriteLine("Breastfeeds: {0}", this.Breastfeeds);
			Console.WriteLine("-------------------------------");
		}
		public virtual void MakeSound() { }
		public virtual void Eat(Food food) { }
		public void Move(string direction, int speed)
		{
			Console.WriteLine($"{this.Name} started moving {direction} with {speed} km/h");
		}
		public virtual void Stop()
		{
			Console.WriteLine($"{this.Name} stopped moving");
		}
	}
}
