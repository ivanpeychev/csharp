using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter blacklist word:");
        var line = Console.ReadLine();

        var blackList = new List<string>();

        while (line != "end")
        {
            blackList.Add(line);
            Console.WriteLine();
            Console.WriteLine("Enter blacklist word:");
            line = Console.ReadLine();
        }

        var songList = new List<string>();

        Console.WriteLine();
        Console.WriteLine("Enter song name:");
        var song = Console.ReadLine();

        while (song != "end")
        {
            bool inBlacklist = false;
            foreach (var blackWord in blackList)
            {
                if (song.ToLower().Contains(blackWord.ToLower()))
                {
                    inBlacklist = true;
                    break;
                }
            }

            if (!inBlacklist)
            {
                songList.Add(song);
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Song is in the blacklist!");
            }

            Console.WriteLine();
            Console.WriteLine("Enter song name:");
            song = Console.ReadLine();
        }

        songList.Sort();
        Console.WriteLine();
        Console.WriteLine(string.Join(Environment.NewLine, songList));
    }
}