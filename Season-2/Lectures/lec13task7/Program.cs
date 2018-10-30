using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_7
{
	class Program
	{
		static void Main(string[] args)
		{
			while (true)
			{
				Console.WriteLine("Enter words: ");
				string[] words = Console.ReadLine()
					.Split(' ');

				int count = 0;
				for (int i = 0; i < words.Length; i++)
				{
					string currentWord = words[i];
					if (currentWord == currentWord.ToUpper())
					{
						count++;
					}
				}

				Console.WriteLine($"{count} of the words are with all capital letters.");
			}
		}
	}
}
