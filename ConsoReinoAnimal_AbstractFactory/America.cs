using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoReinoAnimal_AbstractFactory
{
    class America : Continente
    {
        public override Carnivoro crearCarnivoro()
        {
            return new Lobo();
        }

        public override Herviboro crearHerviboro()
        {
            return new Vaca();
        }
    }
}
