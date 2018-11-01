using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		var inputList = Console.ReadLine()
			.Split(' ')
			.Select(int.Parse)
			.ToList();

		int n = int.Parse(Console.ReadLine());

		for (int i = 1; i <= n; i++)
		{
			for (int j = 1; j < inputList.Count - 1; j++)
			{
				int left = inputList[j - 1];
				int middle = inputList[j];
				int right = inputList[j + 1];
				GrowGrapes(ref left, ref middle, ref right);
				inputList[j - 1] = left;
				inputList[j] = middle;
				inputList[j + 1] = right;
			}
			Console.WriteLine($"Round {i}: {string.Join(" ", inputList)}");
			break;
		}
	}

	public static void GrowGrapes(ref int left, ref int middle, ref int right)
	{
		Console.WriteLine($"{left} : {middle} : {right}");
		if (middle > left && middle > right)
		{
			// Greater
			if (left > 0 && right > 0)
			{
				middle += 2;
				left--;
				right--;
			}
			else if (left > 0 && right < 1)
			{
				middle++;
				left--;
			}
			else if (left < 1 && right > 0)
			{
				middle++;
				right--;
			}
		}
		// Lesser
		else if (middle < left && middle < right)
		{
			if (middle > 0)
			{
				middle--;
				right++;
				left++;
			}
		}
		Console.WriteLine($"{left} : {middle} : {right}");
		Console.WriteLine();
	}
}