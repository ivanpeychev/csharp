using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main(string[] args)
	{
		var myList = "20 8 12 13 4 4 8 5"
			.Split(' ')
			.Select(int.Parse)
			.ToList();

		var myDigits = new int[Convert.ToInt32(myList.Max())];

		for (int i = 0; i < myList.Count; i++)
		{
			int currentPosition = myList[i];
			myDigits[currentPosition - 1]++;
		}
		Console.WriteLine(string.Join(" ", myDigits));

		string result = string.Empty;
		
		for (int i = 0; i < myDigits.Length; i++)
		{
			if (myDigits[i] > 1)
			{
				result += (i + 1).ToString() + " and ";
			}
		}
		Console.WriteLine(result.Substring(0, result.Length - 5) + " are already present in the list.");
	}
}