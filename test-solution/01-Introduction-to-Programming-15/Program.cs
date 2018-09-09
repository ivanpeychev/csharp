using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		DateTime bday;

		Console.WriteLine("Enter birth date?");
		while (true)
		{
			DateTime.TryParse(Console.ReadLine(), out bday);
			if (bday != null && bday != DateTime.MinValue)
			{
				break;
			}
			else
			{
				Console.WriteLine("Input date not in correct format. Try again:");
			}
		}
		int age = DateTime.Now.Subtract(bday).Days / 365;

		Console.WriteLine($"You are {age} years old.");
		Console.WriteLine($"You will be {age + 10} years old in 10 years.");
	}
}