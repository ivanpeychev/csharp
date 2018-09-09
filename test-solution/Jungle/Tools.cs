using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Tools
{
	public static string GetDeterminer(string word)
	{
		string FirstLetter = word.Substring(0, 1);
		string determiner = FirstLetter == "a" || FirstLetter == "e" || FirstLetter == "i" || FirstLetter == "u" || FirstLetter == "o" || FirstLetter == "y" ? "an" : "a";
		return determiner;
	}

	public static string GetPronoun(char gender)
	{
		string pronoun;
		if (gender == 'm')
		{
			pronoun = "he";
		}
		else if (gender == 'f')
		{
			pronoun = "she";
		}
		else
		{
			pronoun = "it";
		}
		return pronoun;
	}

}