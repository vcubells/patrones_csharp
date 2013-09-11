using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documentos_FactoryMethod
{
    class Tesis : Documento
    {
        public override void Crear()
        {
            paginas.Add(new Resumen());
            paginas.Add(new INtroduccion());
            paginas.Add(new Desarrollo());
            paginas.Add(new Conclusiones());
            paginas.Add(new Bibliografia());
        }

    }
}
