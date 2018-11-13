using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
	static void Main()
	{
		var dict = new Dictionary<string, int>();

		while (true)
		{
			string input = Console.ReadLine().Trim();
			if (input == "Over")
				break;

			var currentArr = input
				.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries)
				.Select(s => s.Trim())
				.ToArray();

			var kvp = EnsureProperPhoneEntry(currentArr);

			dict.Add(kvp.Key, kvp.Value);
		}

		foreach (var item in dict)
		{
			Console.WriteLine($"{item.Key} -> {item.Value}");
		}
	}

	public static KeyValuePair<string, int> EnsureProperPhoneEntry(string[] arr)
	{
		var key = arr[0];
		var val = arr[1];

		string newKey = string.Empty;
		int newVal = 0;

		if (int.TryParse(val, out int num))
		{
			newKey = key;
			newVal = num;
		}
		else
		{
			newKey = val;
			newVal = int.Parse(key);
		}
		return new KeyValuePair<string, int>(newKey, newVal);
	}
}