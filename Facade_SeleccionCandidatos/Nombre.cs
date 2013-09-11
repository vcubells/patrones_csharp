using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_SeleccionCandidatos
{
    class Nombre
    {
        public bool validaNombre(Candidato c, string uni)
        {
            Console.WriteLine("Validando nombre para candidato {0}", c.Nombre);

            return (c.Nombre != "Luis" && uni == "MIT");
        }
    }
}
