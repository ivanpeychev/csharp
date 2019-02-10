using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace L6_T0_1
{
	class Program
	{
		static void Main(string[] args)
		{
			var list = new List<int>(Enumerable.Range(0, 1500).ToList());
			//var task = Task.Run(() => ClearListAsync(list));
			Console.WriteLine($"Main thread: {Thread.CurrentThread.ManagedThreadId} started");

			IncrementNumber(0, 100000000);

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "end")
				{
					break;
				}
			}
		}

		public async static void IncrementNumber(int num, int howMuch)
		{
			object lockObj = new object();
			for (int i = 0; i < 8; i++)
			{
				await Task.Run(() =>
				{
					Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId} started");
					for (int j = 0; j < howMuch; j++)
					{
						num++;
						
						//lock (lockObj)
						//{
						//}
					}
					Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId} finished");
				});
			}
			Console.WriteLine($"Number: {num}");
		}

		static void PrintNumsInRange(int min, int max)
		{
			Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId} started");
			int count = 0;
			for (int i = min; i < max; i++)
			{
				Thread.Sleep(5);
				count++;
			}
			Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId} finished with count {count}");
		}

		static async void ClearListAsync(List<int> list)
		{
			int count = 0;
			for(int i = 0; i < 4; i++)
			{
				await Task.Run(() =>
				{
					Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId} started");
					while (list.Count > 0)
					{
						list.RemoveAt(list.Count - 1);
						Thread.Sleep(5);
						count++;
					}
					Console.WriteLine($"Current thread: {Thread.CurrentThread.ManagedThreadId} finished with count {count}");
				});
			}
		}
	}
}
