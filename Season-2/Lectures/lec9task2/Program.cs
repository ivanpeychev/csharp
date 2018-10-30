using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 7;
        int c = 2;

        int smallest = GetMin(a, b);
        smallest = GetMin(smallest, c);

        Console.WriteLine(smallest);
    }

    static int GetMin(int a, int b)
    {
        if (a < b)
        {
            return a;
        }

        return b;
    }
}