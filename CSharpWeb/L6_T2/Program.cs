using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

class Program
{
	static void Main()
	{
		var server = new HTTPServer();
		server.Start();

		while (true)
		{
			string command = Console.ReadLine();
			if (command == "end")
			{
				break;
			}
		}
	}
}