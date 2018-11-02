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

        Console.WriteLine(myList.Length / 2);

        for (int i = 0; i < myList.Length / 2; i++)
        {
            var leftIndex = i;
            var rightIndex = myList.Length - 1 - i;

            var temp = myList[leftIndex];
            myList[leftIndex] = myList[rightIndex];
            myList[rightIndex] = temp;

            //Console.WriteLine($"Left: {leftIndex} Right: {rightIndex}");
        }

        Console.WriteLine(string.Join(" ", myList)); 
    }
}