using SIS.WebServer.Routing.Contracts;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SIS.WebServer
{
    public class Server
    {
        private const string LocalHost = "127.0.0.1";

        private readonly int port;

        private readonly TcpListener tcpListener;

        private IServerRoutingTable serverRoutingTable;

        private bool isRunning;

        public Server(int port, IServerRoutingTable serverRoutingTable)
        {
            this.port = port;

            this.serverRoutingTable = serverRoutingTable;

            this.tcpListener = new TcpListener(IPAddress.Parse(LocalHost), port);
        }

        private void Listen(Socket client)
        {
            var connectionHandler = new ConnectionHandler(client, this.serverRoutingTable);
            connectionHandler.ProcessRequest();
        }

        public void Run()
        {
            this.tcpListener.Start();
            this.isRunning = true;

            System.Console.WriteLine($"Server started at http://{LocalHost}:{this.port}");

            while (this.isRunning)
            {
                System.Console.WriteLine("Waiting for client...");

                var client = this.tcpListener.AcceptSocket();

                this.Listen(client);
            }
        }
    }
}
