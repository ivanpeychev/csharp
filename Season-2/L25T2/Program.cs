using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25T2
{
	class Program
	{
		static void Main()
		{
			var myList = "10 30 15 20 50 5"
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			myList.Sort();
			myList.Reverse();

			Console.WriteLine(string.Join(" ", myList.Take(3)));
		}
	}
}
