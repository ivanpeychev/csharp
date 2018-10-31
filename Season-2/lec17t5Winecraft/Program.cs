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
				ProcessGrapes(ref left, ref middle, ref right);
				inputList[j - 1] = left;
				inputList[j] = middle;
				inputList[j + 1] = right;
			}
			Console.WriteLine(string.Join(" ", inputList.Select(el => el < n)));
			inputList.Remove()
		}
	}

	private static void ProcessGrapes(ref int left, ref int middle, ref int right)
	{
		//
	}
}