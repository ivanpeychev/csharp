using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	interface IMammal : ICreature
	{
		int NumberOfLegs { get; }
		char Gender { get; }
		void Drink();
		void Eat(Food food);
	}
}