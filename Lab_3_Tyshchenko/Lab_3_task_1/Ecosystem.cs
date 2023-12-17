using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_task_1
{
    public class Ecosystem
    {
        public List<LivingOrganism> Organisms { get; set; }

        public Ecosystem()
        {
            Organisms = new List<LivingOrganism>();
        }

        public void SimulateInteraction()
        {
            foreach (var organism in Organisms)
            {
            }
        }
    }
}