using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoReinoAnimal_AbstractFactory
{
    class Lobo : Carnivoro
    {
        public override void Comer(Herviboro h)
        {
            Console.WriteLine("{0} se come a {1}", this.GetType().Name, h.GetType().Name);
        }
    }
}
