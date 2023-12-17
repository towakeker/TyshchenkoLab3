using System;

namespace Lab_3_task_3
{
    public class Vehicle: IDriveable
    {
        public Vehicle(string car, int i, int i1)
        {
            throw new NotImplementedException();
        }

        public string Type { get; }
        public int Speed { get; }
        public int Size { get; }
        
        public void Do_move()
        {
            Console.WriteLine($"{Type} is moving at a speed of {Speed} km/h.");
        }

        public void Do_stop()
        {
            Console.WriteLine($"{Type} - stop.");
        }
    }
}