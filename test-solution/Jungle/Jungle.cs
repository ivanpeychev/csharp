using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	class Jungle
	{
		public string Location;
		public List<Animal> Animals { get; }

		public Jungle(string location)
		{
			Location = location;
			Animals = new List<Animal>();
		}
	}
}
