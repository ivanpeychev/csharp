using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	class Program
	{
		static void Main()
		{
			Jungle Jungle = new Jungle("Chile");

			Jungle.Animals.Add(new Cat("Gosho", 18, 'f'));
			Jungle.Animals.Add(new Dog("Tosho", 25, 'm'));

			foreach (var animal in Jungle.Animals)
			{
				animal.GetInfo();
				animal.MakeSound();
						Console.WriteLine();
				animal.Move("south", 15);
				animal.Move("west", 7);
						Console.WriteLine();
				animal.Eat(new Food("steak", "meat", 15));
				animal.Eat(new Food("apple", "fruit", 25));
			}

			Jungle.Animals[0].Stop();
			Jungle.Animals[1].Stop();
		}
	}
}
