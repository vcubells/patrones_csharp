using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteradores
{
    interface IIterador <T>
    {
        T Inicio();
        T Siguiente();
        bool esFin();
        T Ultimo();
        void Paso(int p);
    }
}
