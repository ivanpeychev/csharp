using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
        int result;
        bool check = false;
        do
        {
            Console.WriteLine("Please enter valid integer: ");
            check = int.TryParse(Console.ReadLine(), out result);
        }
        while (!check);

        Console.WriteLine($"Your value is: {result}");
	}
}