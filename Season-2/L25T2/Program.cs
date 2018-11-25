using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25T2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = "10 30 15 20 50 5"
                .Split(' ')
                .OrderByDescending(i => i)
                .ToList();

            myList.ForEach(Console.WriteLine);
        }
    }
}
