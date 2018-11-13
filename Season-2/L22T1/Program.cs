using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
	static void Main()
	{
		var str = "The quick brown fox jumps over the lazy dog";

		var res = new Dictionary<char, int>();

		foreach (var letter in str)
		{
			if (!res.ContainsKey(letter))
			{
				res.Add(letter, 0);
			}

			res[letter]++;
		}

		foreach (var letter in res)
		{
			Console.WriteLine($"{letter.Key} -> {letter.Value}");
		}
	}
}