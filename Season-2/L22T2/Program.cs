using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		var dict = new Dictionary<string, string>();

		while (true)
		{
			string input = Console.ReadLine().Trim();
			if (input == "end")
				break;

			var currentArr = input
				.Split(new[] { '=' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(s => s.Trim())
				.ToArray();

			var key = currentArr[0];
			var val = currentArr[1];

			if (dict.ContainsKey(val))
			{
				val = dict[val];
			}

			if (!dict.ContainsKey(key))
			{
				dict.Add(key, val);
			}
			else
			{
				dict[key] = val;
			}
		}

		foreach (var item in dict)
		{
			Console.WriteLine($"{item.Key} === {item.Value}");
		}
	}
}