using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        var n = int.Parse(Console.ReadLine());
        var journal = new Dictionary<string, List<double>>();
        for (int i = 0; i < n; i++)
        {
            //Console.WriteLine("Enter name and grade (or \"end\" command):");
            string input = Console.ReadLine().Trim();
            //if (input == "end")
            //    break;

            var currentLine = input.Split(' ').Select(j => j.Trim()).ToArray();

            string key = currentLine[0];
            double val = double.Parse(currentLine[1]);

            if (!journal.ContainsKey(key))
            {
                journal.Add(key, new List<double>());
            }
            journal[key].Add(val);
        }

        foreach (var record in journal)
        {
            Console.WriteLine($"{record.Key} -> {string.Join(" ", record.Value.Select(i => string.Format("{0:F2}", i)))} (avg: {string.Format("{0:F2}", record.Value.Average())})");
        }
        Console.ReadKey();
    }
}