using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public static class DownloadManager
{
    public static void DownloadFile(string url)
    {
        Console.WriteLine("Downloading..");
        string fileName = ExtractFileNameFromUrl(url);
        using (WebClient client = new WebClient())
        {
            client.DownloadFile(url, fileName);
            Console.WriteLine("Download Successful");
            Process.Start(fileName);
        }
    }

    public static async void DownloadFileAsync(string url)
    {
        Console.WriteLine("Downloading..");
        string fileName = ExtractFileNameFromUrl(url);
        using (WebClient client = new WebClient())
        {
            await client.DownloadFileTaskAsync(url, fileName);
            Console.WriteLine("Download Successful");
            Process.Start(fileName);
        }
    }

    private static string ExtractFileNameFromUrl(string url)
    {
        return url.Substring(url.LastIndexOf("/") + 1);
    }
}