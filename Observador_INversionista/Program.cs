using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observador_INversionista
{
    class Program
    {
        static void Main(string[] args)
        {
            Bolsa b = new Bolsa();
            for(int i=0; i < 10; ++i)
                b.Registrar(new InversionistaC());

            b.Accion = 8.76f;

        }
    }
}
