using System;

namespace Lab_3_task_2
{
    using System;

    public class Computer
    {
        public string IpAddress { get; private set; }
        public int Power { get; set; }
        public string OperatingSystem { get; set; }

        public Computer(string ipAddress, int power, string operatingSystem)
        {
            IpAddress = ipAddress;
            Power = power;
            OperatingSystem = operatingSystem;
        }

        public void ConnectTo(IConnectable device)
        {
            Console.WriteLine($"Computer {IpAddress} is connecting to {device}");
        }

        public void DisconnectFrom(IConnectable device)
        {
            Console.WriteLine($"Computer {IpAddress} is disconnecting from {device}");
        }

        public void SendData(string data)
        {
            Console.WriteLine($"Computer {IpAddress} is sending data: {data}");
        }

        public void ReceiveData(string data)
        {
            Console.WriteLine($"Computer {IpAddress} received data: {data}");
        }

        public override string ToString()
        {
            return $"Computer ({IpAddress})";
        }
    }

    }