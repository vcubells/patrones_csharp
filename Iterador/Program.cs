using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteradores
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista<string> l = new Lista<string>();
            for (int i = 0; i < 10; ++i)
            {
                l.Adiciona("Persona " + i);
            }

            IIterador<string> it = l.crearIterador();
            it.Paso(3);
            for (string s = it.Inicio(); !it.esFin(); s = it.Siguiente())
            {
                Console.WriteLine("{0}", s);
            }

            Console.ReadKey();


        }
    }
}
