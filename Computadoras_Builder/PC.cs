using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computadoras_Builder
{
    abstract class PC
    {
        protected Computadora pc = new Computadora();

        public abstract void crearMB();
        public abstract void crearCPU();
        public abstract void crearRAM();
        public abstract void crearHDD();

        public void construye()
        {
            pc.Mostrar();
        }
    }
}
