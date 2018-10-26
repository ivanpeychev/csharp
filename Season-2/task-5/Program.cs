using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string result = "";

        int number = 12;
        int toBase = 2;

        int num = number;

        while (num > toBase)
        {
            result = (toBase - 1) + result ;
            num -= toBase;
        }

        result = (number % toBase) + result;

        Console.WriteLine(result);
    }

}