using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var myList = "4 3 -1 2 5 0 1 9 8 6 7 -2".Split(' ').Select(int.Parse).ToList();
        int k = myList.Count / 4;

        var startList = myList.Take(k).Reverse().ToList();
        var middleList = myList.Skip(k).Take(k * 2).ToList();
        var endList = myList.Skip(k * 3).Take(k).Reverse().ToList();

        for (int i = 0; i < k * 2; i++)
        {
            if (i < k)
            {
                middleList[i] += startList[i];
            }

            if (i >= k)
            {
                middleList[i] += endList[i - k];
            }
        }

        Console.WriteLine(string.Join(" ", startList));
        Console.WriteLine(string.Join(" ", middleList));
        Console.WriteLine(string.Join(" ", endList));
    }
}