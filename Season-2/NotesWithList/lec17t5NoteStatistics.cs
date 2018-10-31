using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class lec17t5NoteStatistics
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
			{ 466.16, "A#" },
			{ 493.88, "B"  }
		};

		var inputFreqs = Console.ReadLine()
			.Split(' ')
			.Select(double.Parse)
			.ToList();

		var naturals = new List<KeyValuePair<double, string>>();
		var sharps = new List<KeyValuePair<double, string>>();
		var allNotes = new List<KeyValuePair<double, string>>();

		foreach (double key in inputFreqs)
		{
			if (notes.TryGetValue(key, out string value))
			{
				if (value.Contains("#"))
				{
					sharps.Add(new KeyValuePair<double, string>(key, value));
				}
				else
				{
					naturals.Add(new KeyValuePair<double, string>(key, value));
				}
				allNotes.Add(new KeyValuePair<double, string>(key, value));
			}
		}

		if (allNotes.Count > 0)
		{
			Console.WriteLine($"Notes: {string.Join(" ", allNotes.Select(i => i.Value))}");
			Console.WriteLine($"Naturals: {string.Join(", ", naturals.Select(i => i.Value))}");
			Console.WriteLine($"Sharps: {string.Join(", ", sharps.Select(i => i.Value))}");
			Console.WriteLine($"Naturals sum: {naturals.Select(i => i.Key).Sum()}");
			Console.WriteLine($"Sharps sum: {sharps.Select(i => i.Key).Sum()}");
		}

		//allNotes.ForEach(i => Console.Beep((int)i.Key, 300));
	}
}
