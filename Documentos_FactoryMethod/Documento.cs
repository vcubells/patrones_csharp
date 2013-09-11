using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Documentos_FactoryMethod
{
    class Documento
    {
        protected List<Pagina> paginas = new List<Pagina>();

        public Documento()
        {
            this.Crear();
        }

        public virtual void Crear()
        {
            paginas.Add(new Resumen());
            paginas.Add(new Desarrollo());
            paginas.Add(new Conclusiones());
            paginas.Add(new Agradecimientos());
        }

        public void Mostrar()
        {
            Console.WriteLine("{0}", this.GetType().Name);
            foreach (Pagina p in paginas)
            {
                Console.WriteLine("--{0}", p.GetType().Name);
            }
        }
    }
}
