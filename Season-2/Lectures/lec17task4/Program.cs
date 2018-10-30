using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args)
	{
		Console.WriteLine("Enter primal list: ");
		var primalList = Console.ReadLine()
			.Split(' ')
			.ToList();

		var finalList = new List<string>();

		Console.WriteLine("How many lines do you want to enter:");
		int lineCount = int.Parse(Console.ReadLine());

		var lines = new List<List<string>>();

		for (int i = 0; i < lineCount; i++)
		{
			Console.WriteLine($"Enter line {i + 1}:");
			var currentLine = Console.ReadLine().Split(' ').ToList();

			lines.Add(currentLine);
		}

		foreach (var line in lines)
		{
			foreach (var item in line)
			{
                foreach (var number in primalList.ToArray())
                {
                    if (number == item)
                    {
                        primalList.Remove(number);
                    }
                    else
                    {
                        primalList.Add(item);
                    }
                }
			}
		}

        primalList.Sort();
		Console.WriteLine("Sorted primal list: " + string.Join(" ", primalList));
	}
}