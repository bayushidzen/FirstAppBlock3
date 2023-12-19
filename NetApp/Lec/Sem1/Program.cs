using System.Net;
using System.Net.Sockets;

namespace Lec1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (Socket listener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                var localEndPoint = new IPEndPoint(System.Net.IPAddress.Parse("127.0.0.1"), 12345);
                listener.Blocking = true;
                listener.Bind(localEndPoint);
                listener.Listen(100);
                Console.WriteLine("Waiting for connection");
                var socketListener = listener.Accept();
                Console.WriteLine("Connected");
                listener.Close();
            }
        }
    }
}
