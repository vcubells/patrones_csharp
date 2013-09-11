using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoReinoAnimal_AbstractFactory
{
    class ReinoAnimal
    {
        Herviboro _herviboro;
        Carnivoro _carnivoro;

        public ReinoAnimal(Continente c)
        {
            _herviboro = c.crearHerviboro();
            _carnivoro = c.crearCarnivoro();
        }

        public void Banquete()
        {
            _carnivoro.Comer(_herviboro);
        }
    }
}
