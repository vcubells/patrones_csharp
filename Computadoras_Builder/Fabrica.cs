using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computadoras_Builder
{
    class Fabrica
    {
        public PC Tipo { get; set; }

        public Fabrica(PC pc)
        {
            Tipo = pc;
            Tipo.crearCPU();
            Tipo.crearMB();
            Tipo.crearHDD();
            Tipo.crearRAM();
        }

    }
}
