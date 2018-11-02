using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter array of numbers:");
        var myList = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToList();

        int smallest = int.MaxValue;

        foreach (var item in myList)
        {
            if (item < smallest)
            {
                smallest = item;
            }
        }

        Console.WriteLine(smallest);
    }
}