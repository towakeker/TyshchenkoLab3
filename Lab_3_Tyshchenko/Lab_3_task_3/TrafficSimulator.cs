using System;

namespace Lab_3_task_3
{
    public class TrafficSimulator
    {
        public void SimulateTraffic(IDriveable vehicle, Road road)
        {
            Console.WriteLine($"Simulating traffic on a road {road.Length} km long with {road.Lanes} lane(s).");
            Console.WriteLine($"Current traffic level: {road.TrafficLevel}");

            vehicle.Do_move();

            if (road.TrafficLevel > 5)
            {
                Console.WriteLine("Traffic is heavy. Vehicles are stopping.");
                vehicle.Do_stop();
            }
            else
            {
                Console.WriteLine("Traffic is flowing smoothly.");
            }
        }

    }
}