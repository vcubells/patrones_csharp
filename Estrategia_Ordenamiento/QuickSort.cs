using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estrategia_Ordenamiento
{
    class QuickSort : Ordenamiento
    {
        public override void Ordena(List<string> lista )
        {
            Console.WriteLine("Ordenamiento por QuickSort");
            lista.Sort();

            foreach (string o in lista)
                Console.WriteLine("{0}", o);
        }
    }
}
