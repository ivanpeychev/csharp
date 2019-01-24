using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        string url = "https://introprogramming.info/wp-content/uploads/2018/07/CSharp-Principles-Book-Nakov-v2018.pdf";

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "end")
                break;

            if (command == "download file")
               DownloadManager.DownloadFileAsync(url);
        }
    }
}