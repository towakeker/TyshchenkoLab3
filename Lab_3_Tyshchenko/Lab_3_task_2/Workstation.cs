using System;
using System.Net;

namespace Lab_3_task_2
{
    public class Workstation:Computer
    {
        public Workstation(string ipAddress, int power, string operatingSystem) : base(ipAddress, power, operatingSystem)
        {
            
        }
        public void Do_work()
        {
            Console.WriteLine($"{IpAddress} is working.");
        }
    }
}