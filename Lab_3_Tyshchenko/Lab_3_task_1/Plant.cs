using System;

namespace Lab_3_task_1
{
    public class Plant: LivingOrganism, IReproducible
    {
        public Plant(double energy, int age, double size) : base(energy, age, size) { }

        public void Reproduce()
        {
            Console.WriteLine("The plant reproduces");
        }
    }
}