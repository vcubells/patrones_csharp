using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computadoras_Builder
{
    class Escritorio : PC
    {
        public override void crearMB()
        {
            pc.set("Motherboard", "Intel 825");
        }

        public override void crearCPU()
        {
            pc.set("Procesador", "Core i7");
        }

        public override void crearRAM()
        {
            pc.set("Memoria", "K 4GB");
        }

        public override void crearHDD()
        {
            pc.set("Disco Duro", "Lacie 2TB");
        }
    }
}
