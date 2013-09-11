using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_SeleccionCandidatos
{
    class Seleccion
    {
        private Idioma idioma = new Idioma();
        private Promedio promedio = new Promedio();
        private Nombre nombre = new Nombre();

        public bool esElegible(Candidato c, string uni)
        {
            Console.WriteLine("Validando elegibilidad para el candidato {0} aplicando a {1}", c.Nombre, uni);

            bool elegible = true;

            if (!idioma.validaIdioma(c, uni))
            {
                elegible = false;
            }
            else if (!promedio.validaPromedio(c, uni))
            {
                elegible = false;
            }
            else if (!nombre.validaNombre(c, uni))
            {
                elegible = false;
            }

            return elegible;
        }
    }
}
