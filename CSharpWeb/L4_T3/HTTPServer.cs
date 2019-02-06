using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

public class HTTPServer : IHTTPServer
{
    private TcpListener tcpListener;
    private bool isWorking;

    public HTTPServer()
    {
        this.tcpListener = new TcpListener(IPAddress.Parse("127.0.0.1"), 4000);
    }
    public void Start()
    {
        this.tcpListener.Start();
        this.isWorking = true;
        Console.WriteLine("Server started!");
        while (this.isWorking)
        {
            Console.WriteLine("Listening..");
            var client = this.tcpListener.AcceptTcpClient();
            var buffer = new byte[10240];
            var stream = client.GetStream();
            var readLenght = stream.Read(buffer, 0, buffer.Length);
            var requestText = Encoding.UTF8.GetString(buffer, 0, readLenght);
            Console.WriteLine(new string('=', 60));
            Console.WriteLine(requestText);

            var responseText = "It works!";
            var responseBytes = Encoding.UTF8.GetBytes(
                "HTTP/1.0 200 OK" + Environment.NewLine +
                "Content-Length: " + responseText.Length + Environment.NewLine +
                "Content-Type: text/html" + Environment.NewLine +
                Environment.NewLine +
                responseText
                );
            stream.Write(responseBytes);
        }
    }
    public void Stop()
    {
        this.tcpListener.Stop();
        this.isWorking = false;
    }
}
public interface IHTTPServer
{
    void Start();

    void Stop();
}