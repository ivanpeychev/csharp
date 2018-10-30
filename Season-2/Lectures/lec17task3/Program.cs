using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lec17task3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter sequence N:");
            var nList = Console.ReadLine()
                .Split(' ')
                .ToList();

            Console.WriteLine("Enter sequence Camel's back:");
            var m = int.Parse(Console.ReadLine());

            if (nList.Count > m)
            {
                int rounds = 0;

                while (nList.Count > m)
                {
                    nList.RemoveAt(0);
                    nList.RemoveAt(nList.Count - 1);
                    rounds++;
                }

                Console.WriteLine(rounds + " rounds");
                Console.WriteLine($"remaining: {string.Join(" ", nList)}");
            }
            else
            {
                Console.WriteLine($"already stable: {string.Join(" ", nList)}");
            }


        }
    }
}
