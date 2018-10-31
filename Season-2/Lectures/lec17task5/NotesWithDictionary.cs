using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class NotesWithDictionary
{
	static void Main()
	{
		var notes = new Dictionary<double, string>() 
		{
			{ 261.63, "C"  },
			{ 277.18, "C#" },
			{ 293.66, "D"  },
			{ 311.13, "D#" },
			{ 329.63, "E"  },
			{ 349.23, "F"  },
			{ 369.99, "F#" },
			{ 392.00, "G"  },
			{ 415.30, "G#" },
			{ 440.00, "A"  },
			{ 466.00, "A#" },
			{ 493.88, "B"  }
		};

		var inputFreqs = Console.ReadLine()
			.Split(' ')
			.Select(double.Parse)
			.ToList();

		var naturals = new Dictionary<double, string>();
		var sharps = new Dictionary<double, string>();
		var outputNotes = new Dictionary<double, string>();

		foreach (var inputItem in inputFreqs)
		{
			if(notes.TryGetValue(inputItem, out string value))
			{
				if (value.Contains("#"))
				{
					sharps.Add(inputItem, value);
				}
				else
				{
					naturals.Add(inputItem, value);
				}
				outputNotes.Add(inputItem, value);
			}
		}

		if (outputNotes.Count > 0)
		{
			Console.WriteLine($"Notes: {string.Join(" ", outputNotes.Values)}");
			Console.WriteLine($"Naturals: {string.Join(" ", naturals.Values)}");
			Console.WriteLine($"Sharps: {string.Join(" ", sharps.Values)}");
			Console.WriteLine($"Naturals' sum: {naturals.Keys.Sum()}");
			Console.WriteLine($"Sharps' sum: {sharps.Keys.Sum()}");
		}
	}
}
