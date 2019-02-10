using System;
using System.Threading;
using System.Threading.Tasks;

namespace L6_T1
{
	class Program
	{
		static void Main()
		{
			PrintEvenNumbersInRange(1, 100);

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "end")
				{
					break;
				}
			}
		}

		static async void PrintEvenNumbersInRange(int from, int to)
		{
			object lockObj = 0;
			int count = 0;
			await Task.Run(() =>
			{
				Console.WriteLine("STARTED!");
				for (int i = from; i < to; i++)
				{
					Thread.Sleep(50);
					if (i % 2 == 0)
					{
						//Console.WriteLine(i);
						lock (lockObj)
						{
							count++;
						}
					}
				}
			});
			Console.WriteLine("Thread finished!");
			Console.WriteLine(count);
		}
	}
}
