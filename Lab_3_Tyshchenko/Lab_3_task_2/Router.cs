using System;
using System.Collections.Generic;
using System.Net;

namespace Lab_3_task_2
{
    public class Router: Computer
    {
        public List<IConnectable> ConnectedDevices { get; } = new List<IConnectable>();
        public Router(string ipAddress, int power, string operatingSystem) : base(ipAddress, power, operatingSystem)
        {
            
        }
        public void ConnectTo(IConnectable device)
        {
            ConnectedDevices.Add(device);
            Console.WriteLine($"Router {IpAddress} is connecting to {device}");
        }

        public void DisconnectFrom(IConnectable device)
        {
            ConnectedDevices.Remove(device);
            Console.WriteLine($"Router {IpAddress} is disconnecting from {device}");
        }
    }
}