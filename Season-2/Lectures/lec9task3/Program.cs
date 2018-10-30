using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine(RepeatString("ha", 3));
    }

    static string RepeatString(string str, int times)
    {
        string newString = string.Empty;
        for (int i = 0; i < times; i++)
        {
            newString += str;
        }
        return newString;
    }
}