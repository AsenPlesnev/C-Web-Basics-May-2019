using Demo.App.Controllers;
using SIS.HTTP.Enums;
using SIS.HTTP.Headers;
using SIS.HTTP.Requests;
using SIS.HTTP.Responses;
using SIS.WebServer;
using SIS.WebServer.Results;
using SIS.WebServer.Routing;
using SIS.WebServer.Routing.Contracts;
using System;
using System.Globalization;
using System.Text;

namespace Demo.App
{
    class Program
    {
        static void Main(string[] args)
        {
            IServerRoutingTable serverRoutingTable = new ServerRoutingTable();

            serverRoutingTable.Add(HttpRequestMethod.Get, "/",
                request => new HomeController().Index(request));

            Server server = new Server(8000, serverRoutingTable);
            server.Run();
        }

    }
}
