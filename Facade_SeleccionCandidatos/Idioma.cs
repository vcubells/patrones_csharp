using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_SeleccionCandidatos
{
    class Idioma
    {
        public bool validaIdioma(Candidato c, string uni)
        {
            Console.WriteLine("Validando idioma para el candidato {0}", c.Nombre);
            return (c.Idioma == "EN" && uni == "MIT");
        }
    }
}
