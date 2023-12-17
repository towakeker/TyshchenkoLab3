using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var server = new IConnectable("192.168.1.1", 1000, "Windows Server");
            var workstation = new IConnectable("192.168.1.1", 500, "Windows 10");
            var router = new IConnectable("192.168.1.1.1", 800, "Linux OS");

            var network = new Network();
            network.AddDevice(server);
            network.AddDevice(workstation);
            network.AddDevice(router);

            network.ConnectDevices(server, router);
            network.ConnectDevices(workstation, router);

            server.ServeClient(new Client("192.168.1.3", 300, "Windows 10"));

            network.DisconnectDevices(server, router);
            network.DisconnectDevices(workstation, router);
        }
    }
}