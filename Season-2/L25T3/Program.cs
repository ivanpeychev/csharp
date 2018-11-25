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
            string currentWord = word.ToLower();
            if (!resultList.Select(i => i.ToLower()).Contains(currentWord))
            {
                resultList.Add(word);
            }
		}

        Console.WriteLine(string.Join(", ", resultList.Where(i => i.Length < 5).OrderBy(i => i)));
	}
}