using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int n = 10;

        PrintNumbersInRange(0, 10);

        var task = Task.Run(() =>
            PrintNumbersInRange(10, 20));

        Console.WriteLine("Done");
        task.Wait();
    }

    private static void PrintNumbersInRange(int v1, int v2)
    {
        for (int i = v1; i < v2; i++)
        {
            Console.WriteLine(i);
        }
    }
}