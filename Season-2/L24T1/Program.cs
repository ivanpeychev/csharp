using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var cities = new Dictionary<string, HashSet<int>>();
        while (true)
        {
            var input = Console.ReadLine().Trim();
            if (input == "Aggregate")
                break;

            var currentArr = input.Split(' ').ToArray();

            string key = currentArr[0];
            int val = int.Parse(currentArr[1]);

            if (!cities.ContainsKey(key))
            {
                cities.Add(key, new HashSet<int>());
            }
            cities[key].Add(val);
        }

        foreach (var city in cities)
        {
            Console.Write(city.Key + " -> ");
            foreach (var shellCount in city.Value)
            {
                Console.Write(shellCount);
                if (shellCount != city.Value.Last())
                {
                    Console.Write(", ");
                }
            }
            int result = (int)Math.Ceiling(city.Value.Sum() - city.Value.Average());
            Console.WriteLine($" ({result})");
        }
    }
}