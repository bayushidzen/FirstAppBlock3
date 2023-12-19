using System.Net.Sockets;
using System.Net;

namespace Lec1Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                var remoteEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 12345);
                Console.WriteLine("Connecting");
                client.Connect(remoteEndPoint);
                Console.WriteLine("Connected");
                Console.ReadKey();
            }
        }
    }
}
