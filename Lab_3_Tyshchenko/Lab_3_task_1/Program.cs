using System;

namespace Lab_3_task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            var ecosystem = new Ecosystem();
            var animal = new Animal(120, 5, 2);
            var plant = new Plant(50, 2, 1);
            var microorganism = new Microorganism(10, 1, 0.1);

            ecosystem.Organisms.Add(animal);
            ecosystem.Organisms.Add(plant);
            ecosystem.Organisms.Add(microorganism);

            ecosystem.SimulateInteraction();

            Console.ReadKey();
        }
    }
}