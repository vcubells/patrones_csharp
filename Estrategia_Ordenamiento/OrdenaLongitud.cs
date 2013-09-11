using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estrategia_Ordenamiento
{
    class OrdenaLongitud : Ordenamiento
    {
        public override void Ordena(List<string> lista)
        {
            Console.WriteLine("Ordenamiento por Longitud");

            var cadenas = from e in lista
                          orderby e.Length
                          select e;

            foreach (string o in cadenas)
                Console.WriteLine("{0}", o);
        }
    }
}
