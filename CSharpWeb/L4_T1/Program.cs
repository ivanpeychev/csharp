using System;
using System.Net;

class Program
{
    static void Main()
    {
        string input = "http://url-decoder.com/i%23de%25?id=23";
        string decodedUrl = WebUtility.UrlDecode(input);

        Console.WriteLine(decodedUrl);
    }
}