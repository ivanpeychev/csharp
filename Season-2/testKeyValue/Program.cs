using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace testKeyValue
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<KeyValuePair<string, string>>();

            myList.Add(new KeyValuePair<string, string>("hi", "bye"));

            Console.WriteLine(myList[0]);
        }
    }
}
