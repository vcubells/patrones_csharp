﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoReinoAnimal_AbstractFactory
{
    class Oceania : Continente
    {
        public override Carnivoro crearCarnivoro()
        {
            return new Leon();
        }

        public override Herviboro crearHerviboro()
        {
            return new Vaca();
        }
    }
}
