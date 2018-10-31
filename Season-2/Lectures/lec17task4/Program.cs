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

		string primalString = string.Join(" ", primalList);

		foreach (var line in lines)
		{
			foreach (var item in line)
			{
				if (primalList.Exists(i => i == item))
				{
					primalList.RemoveAll(i => i == item);
				}
				else
				{
					primalList.Add(item);
				}
			}
			Console.WriteLine($"List {lines.FindIndex(0, lines.Count, i => i == line) + 1} {string.Join(" ", line)}");
			Console.WriteLine($"Primal list {string.Join(" ", primalList)}");
			Console.WriteLine();
		}

		primalList.Sort();
		Console.WriteLine("Sorted primal list: " + string.Join(" ", primalList));
	}
}