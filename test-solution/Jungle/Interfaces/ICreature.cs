using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	interface ICreature
	{
		string Species { get; }
		int Health { get; }
		int Weight { get; }
		bool IsLiveBorn { get; }
		bool Breastfeeds { get; }
		bool IsDead { get; }

		void Move(string direction, int speed);
		void Stop();
		void MakeSound();
	}
}