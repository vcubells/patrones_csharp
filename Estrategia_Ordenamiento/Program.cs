using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estrategia_Ordenamiento
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaOrdenada l = new ListaOrdenada();
            l.Ordena();

            l.EstableceEstrategia(new OrdenaLongitud());
            l.Ordena();
        }
    }
}
