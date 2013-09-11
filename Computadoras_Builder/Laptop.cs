using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computadoras_Builder
{
    class Laptop : PC
    {
        public override void crearMB()
        {
            pc.set("Motherboard", "Asus 3456");
        }

        public override void crearCPU()
        {
            pc.set("Procesador", "Core i5");
        }

        public override void crearRAM()
        {
            pc.set("Memoria", "K 1GB");
        }

        public override void crearHDD()
        {
            //pc.set("Disco Duro", "Raptor 1TB");
        }
    }
}
