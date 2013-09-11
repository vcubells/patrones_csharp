using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computadoras_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Laptop laptop = new Laptop();
            Fabrica ensamble = new Fabrica(laptop);
            ensamble.Tipo.construye();

            Escritorio escritorio = new Escritorio();
            Fabrica ensamble2 = new Fabrica(escritorio);
            ensamble2.Tipo.construye();

            Console.ReadKey();

        }
    }
}
