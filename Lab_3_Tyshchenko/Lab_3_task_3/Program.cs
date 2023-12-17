using System;

namespace Lab_3_task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var car = new Vehicle("Car", 90, 2);
            var highway = new Road(100, 4, 2, 5);

            TrafficSimulator simulator = new TrafficSimulator();
            simulator.SimulateTraffic(car, highway);
        }
    }
}