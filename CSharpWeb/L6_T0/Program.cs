using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Linq;

namespace L6_T0
{
	class Program
	{
		static void Main()
		{
			CutVideoToPiecesAsync(@"D:\Test\movie.avi", 4);

			while (true)
			{
				string command = Console.ReadLine();
				if (command == "end")
				{
					break;
				}
			}
		}

		static void CutVideoToPieces(string filePath, int pieces)
		{
			var sw = new Stopwatch();
			Console.WriteLine("SYNC STARTED!");

			var directory = Path.GetDirectoryName(filePath);
			string extension = Path.GetExtension(filePath);

			var file = File.ReadAllBytesAsync(filePath);
			var fileBytes = file.Result;
			var bytePiece = fileBytes.Length / pieces;
			Console.WriteLine($"{fileBytes.Length.ToString()} file bytes");

			sw.Start();

			for (int i = 0; i < pieces; i++)
			{
				Console.WriteLine(new string('=', 60));
				int skip = i == 0 ? 0 : i * bytePiece;
				var currentBytes = fileBytes.ToArray().Skip(skip).Take(bytePiece).ToArray();
				Console.WriteLine($"{i.ToString()} conversion");
				Console.WriteLine($"{skip.ToString()} skip");
				Console.WriteLine($"{currentBytes.Length.ToString()} bytes");

				string pathToWrite = Path.Combine(directory, "cut", i.ToString() + extension);
				Console.WriteLine(pathToWrite);
				File.WriteAllBytes(pathToWrite, currentBytes);
			}

			sw.Stop();
			Console.WriteLine($"Sync finished! {sw.Elapsed}");
		}

		static async void CutVideoToPiecesAsync(string filePath, int pieces)
		{
			var sw = new Stopwatch();
			Console.WriteLine("ASYNC STARTED!\n");

			var directory = Path.GetDirectoryName(filePath);
			string extension = Path.GetExtension(filePath);

			var file = File.ReadAllBytesAsync(filePath);
			var fileBytes = file.Result;
			var bytePiece = fileBytes.Length / pieces;
			Console.WriteLine($"{fileBytes.Length.ToString()} file bytes");

			sw.Start();

			for (int i = 0; i < pieces; i++)
			{
				Console.WriteLine(new string('=', 60));
				Console.WriteLine($"Thread number: {Thread.CurrentThread.ManagedThreadId}");
				dynamic currentBytes;
				lock (fileBytes)
				{
					currentBytes = fileBytes.ToArray().Skip(i * bytePiece).Take(bytePiece).ToArray();
				}
				Console.WriteLine($"{(i + 1).ToString()} conversion");
				Console.WriteLine($"{(i * bytePiece).ToString()} skip");
				Console.WriteLine($"{currentBytes.Length.ToString()} bytes");

				string pathToWrite = Path.Combine(directory, "cut", (i + 1).ToString() + extension);
				Console.WriteLine(pathToWrite);

				await Task.Run(() =>
				{
					File.WriteAllBytes(pathToWrite, currentBytes);
				});
			}
			sw.Stop();
			Console.WriteLine($"\nAsync finished! {sw.Elapsed}");
		}
	}
}
