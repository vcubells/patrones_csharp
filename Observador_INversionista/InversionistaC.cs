using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observador_INversionista
{
    class InversionistaC : Inversionista
    {       
        public override void Actualiza(Bolsa b)
        {
            Console.WriteLine("Se ha notificado el cambio a {0}", b.Accion);
        }
    }
}
