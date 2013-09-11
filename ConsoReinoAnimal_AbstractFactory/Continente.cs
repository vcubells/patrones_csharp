using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoReinoAnimal_AbstractFactory
{
    abstract class Continente
    {
        public abstract Carnivoro crearCarnivoro();
        public abstract Herviboro crearHerviboro();
    }
}
