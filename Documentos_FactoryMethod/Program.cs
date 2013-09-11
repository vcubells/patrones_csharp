using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documentos_FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Documento d = new Documento();
            d.Mostrar();

            Tesis t = new Tesis();
            t.Mostrar();

            Console.ReadKey();
        }
    }
}
