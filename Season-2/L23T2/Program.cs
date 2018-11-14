using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        var continents = new Dictionary<string, Dictionary<string, List<string>>>();

        continents.Add("Europe", new Dictionary<string, List<string>>());

            continents["Europe"].Add("Bulgaria", new List<string>());
         
                continents["Europe"]["Bulgaria"].Add("Stara Zagora");
                continents["Europe"]["Bulgaria"].Add("Plovdiv");

            continents["Europe"].Add("France", new List<string>());

        continents["Europe"]["France"].Add("Paris");

        continents.Add("Asia", new Dictionary<string, List<string>>());

            continents["Asia"].Add("India", new List<string>());

                continents["Asia"]["India"].Add("Delhi");

        foreach (var continent in continents)
        {
            Console.WriteLine(continent.Key);
            foreach (var country in continent.Value)
            {
                Console.WriteLine("  " + country.Key);
                foreach (var city in country.Value)
                {
                    Console.WriteLine("    " + city);
                }
            }
        }
    }
}