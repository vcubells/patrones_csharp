using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Facade_SeleccionCandidatos
{
    class Program
    {
        static void Main(string[] args)
        {
            Candidato luis = new Candidato {Nombre = "Higuatzi",
                        Promedio = 99, Idioma = "EN"};

            Seleccion seleccion = new Seleccion();

            bool elegible = seleccion.esElegible(luis, "MIT");

            Console.WriteLine("{0}", (elegible ? "es elegible" : "no aplica"));

            Console.ReadKey();

        }
    }
}
