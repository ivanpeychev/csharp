using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

public static class DownloadManager
{
    public static async void DownloadFileAsync(string url)
    {
        using (WebClient client = new WebClient())
        {
            try
            {
                Console.WriteLine("Downloading..");

                string fileName = ExtractFileNameFromUrl(url);

                await Task.Run(() => client.DownloadFile(url, fileName));

                Console.WriteLine("\nDownload Successful");
            }
            catch (WebException ex)
            {
                throw new WebException(ex.Message, ex);
            }
        }
    }

    private static string ExtractFileNameFromUrl(string url)
    {
        return url.Substring(url.LastIndexOf("/") + 1);
    }
}