using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L25T2
{
<<<<<<< HEAD
    class Program
    {
        static void Main(string[] args)
        {
            var myList = "10 30 15 20 50 5"
                .Split(' ')
                .OrderByDescending(i => i)
                .ToList();

            myList.ForEach(Console.WriteLine);
        }
    }
=======
	class Program
	{
		static void Main()
		{
			var myList = "10 30 15 20 50 5"
				.Split(' ')
				.Select(int.Parse)
				.ToList();

			myList.Sort();
			myList.Reverse();

			Console.WriteLine(string.Join(" ", myList.Take(3)));
		}
	}
>>>>>>> 03fd42c1ccc3498084f642d232d8ece100dfd5ec
}
