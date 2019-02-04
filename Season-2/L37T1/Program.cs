using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L37T1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Time of departure:");
			DateTime departureTime = DateTime.Parse(Console.ReadLine());

			Console.WriteLine("Steps to home:");
			int stepsToHome = int.Parse(Console.ReadLine());

			Console.WriteLine("Seconds per step:");
			int secPerStep = int.Parse(Console.ReadLine());

			Console.WriteLine(departureTime.AddSeconds(stepsToHome * secPerStep));
		}
	}
}
