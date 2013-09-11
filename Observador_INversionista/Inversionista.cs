using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observador_INversionista
{
    abstract class Inversionista
    {
        public abstract void Actualiza(Bolsa b);
    }
}
