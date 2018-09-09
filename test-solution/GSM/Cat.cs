using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	public class Cat : Mammal
	{
		public Cat(string name, int weight, char gender)
			:base (name, weight, gender)
		{
			this.Species = "Cat";
			this.NumberOfLegs = 4;
		}

		public override void MakeSound()
		{
			Console.WriteLine($"{Name}: Meoww!");
		}
	}
}