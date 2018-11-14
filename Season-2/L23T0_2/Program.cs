using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var set = new HashSet<string>();

        set.Add("first");
        set.Add("second");
        set.Add("second");
        set.Add("third");

        foreach (var item in set)
        {
            Console.WriteLine(item);
        }
    }
}