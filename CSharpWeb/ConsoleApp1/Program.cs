using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
	static void Main()
	{
		var list = new List<int>(new int[] { 1, 2, 2, 3, 4, 4 });

		var items = new Dictionary<int, int>();

		for (int i = 0; i < list.Count; i++)
		{
			if (items.Keys.Contains(list[i]))
			{
				items[list[i]]++;
			}
			else
			{
				items.Add(list[i], 1);
			}
		}

		var duplicates = items
			.Where(i => i.Value > 1)
			.ToDictionary(i => i.Key, o => o.Value)
			.Keys
			.ToList();

		Console.WriteLine(string.Join(',', list.Where(i => duplicates.Contains(i))));
	}
}