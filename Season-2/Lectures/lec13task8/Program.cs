using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		while (true)
		{
			string[] array = Console.ReadLine()
				.Split(' ');

			int middle = array.Length / 2;

			bool symmetric = true;

			for (int i = 0; i < middle; i++)
			{
				if (array[i] != array[array.Length - i - 1])
				{
					symmetric = false;
					break;
				}
			}

			Console.WriteLine($"The array is symmetric: {symmetric}");
		}
	}
}