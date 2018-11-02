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
            .ToArray();

        bool sorted = false;
        do
        {
            sorted = true;
            for (int i = 0; i < myList.Length - 1; i++)
            {
                int current = myList[i];
                int next = myList[i + 1];
                if (current < next)
                {
                    myList[i] = next;
                    myList[i + 1] = current;
                    sorted = false;
                }
            }
        } while (!sorted);

        Console.WriteLine(string.Join(" ", myList.Reverse()));
    }
}