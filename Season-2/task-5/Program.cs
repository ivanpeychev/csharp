using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine(IntegerToBase(3, 2));
    }

    static string IntegerToBase(int number, int toBase)
    {
        string result = "";
        int num = number;

        while (num > 0)
        {
            num = (number % toBase);
            result += num.ToString();
        }

        return result;
    }
}