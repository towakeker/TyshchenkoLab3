using System;

namespace Lab_3_task_1
{
    public class Animal : LivingOrganism, IReproducible, IPredator
    {
        public Animal(double energy, int age, double size) : base(energy, age, size) { }

        public void Reproduce()
        {
            Console.WriteLine(" The animal reproduces");
        }

        public void Hunt(LivingOrganism prey)
        {
            Console.WriteLine("An animal hunts on another organism.");
        }
    }
}