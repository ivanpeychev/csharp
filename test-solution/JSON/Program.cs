using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

class Object
{
    public int CheckID { get; set; }
    public int CheckStatus { get; set; }
    public string Note { get; set; } = string.Empty;
}

class Program
{
    static void Main()
    {
        string JSON;

        List<Object> objectList = new List<Object>
        {
            new Object { CheckID = 1, CheckStatus = 2, Note = "Test" },
            new Object { CheckID = 2, CheckStatus = 0},
            new Object { CheckID = 3, CheckStatus = 1, Note = "Mest" }
        };

        JSON = JsonConvert.SerializeObject(objectList);

        Console.WriteLine(JSON);

        Console.WriteLine(objectList.First().CheckID);

        Console.WriteLine();



        List<Object> JSON2 = JsonConvert.DeserializeObject<List<Object>>(JSON);

        foreach (var item in JSON2)
        {
            Console.WriteLine($"CheckID: {item.CheckID}");
            Console.WriteLine($"CheckStatus: {item.CheckStatus}");
            Console.WriteLine($"Note: {item.Note}");
            Console.WriteLine();
        }
    }
}