using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
	class Program
	{
		static void Main(string[] args)
		{
			object ob = "Hello" + " World";

			string str = (string)ob;
		}
	}
}
