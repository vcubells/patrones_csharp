using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_SeleccionCandidatos
{
    class Promedio
    {
        public bool validaPromedio(Candidato c, string uni)
        {
            Console.WriteLine("Validando promedio para el candidato {0}", c.Nombre);
            return (c.Promedio > 98 && uni == "MIT");
        }
    }
}
