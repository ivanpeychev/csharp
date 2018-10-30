using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine(FindNthDigit(123456789, 6 ));
    }

    static string FindNthDigit(long number, int index)
    {
        string numberAsString = number.ToString();

        if (index > numberAsString.Length)
        {
            return "Index outside of number lenght";
        } 

        return numberAsString[numberAsString.Length - index].ToString();
    }
}