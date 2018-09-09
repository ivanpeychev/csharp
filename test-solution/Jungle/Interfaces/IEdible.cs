using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jungle
{
	interface IEdible
	{
		string Name { get; }
		string Type { get; }
		int Energy { get; }
		bool IsPoisonous { get; }
	}
}
