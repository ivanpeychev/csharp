using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

class Program
{
	static void Main()
	{
		var pattern = "<a\\s*href=\"(.*?)\">(.*?)<\\/a>";
		var text = "<ul>   <li>      <a href=\"http://softuni.bg\">SoftUni</a>  <li/>  </ul> <ul>   <li>      <a href=\"http://google.com\">Google</a>  <li/>  </ul>";
		var regEx = new Regex(pattern);
		var replacement = "[URL href=\"$1\">$2[/URL]";

		foreach (Match match in regEx.Matches(text))
		{
			Console.WriteLine(match.Groups[1]);
			Console.WriteLine(match.Groups[2]);
			Console.WriteLine();
		}

		var replaced = regEx.Replace(text, replacement);
		Console.WriteLine(replaced);
	}
}
