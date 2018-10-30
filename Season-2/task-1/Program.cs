using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {
        var myList = Console.ReadLine()
            .Split(' ')
            .ToList();

        string result = string.Empty;

        for (int i = 1; i < myList.Count; i++)
        {
            if (i % 2 == 1)
            {
                result += myList[i];
            }
        }

        Console.WriteLine(result);
    }
}