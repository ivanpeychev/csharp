using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		var lines = System.IO.File.ReadAllLines(@"D:\Desktop\New Text Document.txt");

		foreach (var item in lines)
		{
			Console.WriteLine(item);
		}
	}
}
