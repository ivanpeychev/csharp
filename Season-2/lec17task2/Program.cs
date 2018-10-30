using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter strings separated by space:");
        var stringList = Console.ReadLine()
            .Split(' ')
            .ToList();

        Console.WriteLine("Enter a number:");
        var singleString = Console.ReadLine().Trim();

        while (singleString != "end")
        {
            int index = int.Parse(singleString[0].ToString()); //First digit

            stringList.Insert(index, singleString);

            singleString = Console.ReadLine().Trim();
        }

        Console.WriteLine($"{Environment.NewLine}Your result is: {Environment.NewLine}{string.Join(" ", stringList)}");
    }
}