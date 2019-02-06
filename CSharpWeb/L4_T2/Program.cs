using System;
using System.Net;

namespace L4_T2
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "https/mysite.bg?id=2";
            string decodedUrl = WebUtility.UrlDecode(input);

            bool isValidUrl = Uri.TryCreate(decodedUrl, UriKind.Absolute, out Uri uri);

            if (isValidUrl)
            {
                Console.Write("Is Valid: ");
                Console.WriteLine(isValidUrl);
                Console.Write("Protocol: ");
                Console.WriteLine(uri.Scheme);
                Console.Write("Host: ");
                Console.WriteLine(uri.Host);
                Console.Write("Port: ");
                Console.WriteLine(uri.Port);
                Console.Write("Path: ");
                Console.WriteLine(uri.LocalPath);
                Console.Write("Query: ");
                Console.WriteLine(uri.Query);
                Console.Write("Fragment: ");
                Console.WriteLine(uri.Fragment);
            }
            else
            {
                Console.WriteLine("Invalid URL!");
            }
        }
    }
}