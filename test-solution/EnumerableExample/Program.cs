using System;
using System.Collections.Generic;
using System.Threading;

namespace EnumerableExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loading numbers...");
            foreach (int i in GetNumbers())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Loading numbers with enumerator...");
            foreach (int i in GetNext())
            {
                Console.WriteLine(i);
            }
        }

        static IEnumerable<int> GetNext()
        {
            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                yield return i;
            }
        }

        static IEnumerable<int> GetNumbers()
        {
            List<int> numbers = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                Thread.Sleep(200);
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
