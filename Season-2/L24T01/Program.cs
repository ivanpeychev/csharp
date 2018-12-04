using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		var dict = new Dictionary<string, DateTime>();
		while (true) 
		{
			string input = Console.ReadLine().Trim();
			if (input == "end")
				break;

			var currArr = input.Split(new[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

			DateTime dt = DateTime.Parse(currArr[1]);
			dict.Add(currArr[0], dt);
		}

		dict.OrderBy(i => i.Value)
			.Take(5)
			.Select(i => { Console.WriteLine(string.Format($"{i.Key} {i.Value:dd/MM/yyyy}")); return i; });
		
	}
}