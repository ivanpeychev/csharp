using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	public class Food : IEdible
	{
		public string Name { get; }
		public string Type { get; }
		public int Energy { get; }
		public bool IsPoisonous {
			get
			{
				if (Energy > 20)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		public Food(string name, string type, int energy)
		{
			Name = name;
			Type = type;
			Energy = energy;
		}
	}
}
