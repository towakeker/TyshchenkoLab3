using System;

namespace Lab_3_task_1
{
    public class Microorganism: LivingOrganism, IReproducible
    {
        public Microorganism(double energy, int age, double size) : base(energy, age, size) { }

        public void Reproduce()
        {
            Console.WriteLine("The microorganism reproduces");
        }
    }
    }
