using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_2
{
	class Program
	{
		static void Main(string[] args)
		{
			string inputString = "Robot am I";

			Console.WriteLine(
				string.Join(" ", inputString
					.Split(' ')
					.Reverse())
			);
		}
	}
}
