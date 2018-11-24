using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		var myList = "In SoftUni you can study Java, C#, PHP and JavaScript. JAVA and c# developers graduate in 2-3 years. Go in!"
			.Split(new char[] { '.', ',', ':', ';', '(', ')', '[', ']', '&', '"', '\'', '\\', '/', '!', '?', ' ' }, StringSplitOptions.RemoveEmptyEntries)
			.ToList();

		var resultList = new List<string>();

		foreach (var word in myList)
		{
			var currentWord = word.ToLower();
			if (resultList.Contains(word.ToLower()))
			{
				
			}
		}
	}
}