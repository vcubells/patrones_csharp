using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Estrategia_Ordenamiento
{
    class ListaOrdenada
    {
        Ordenamiento estrategia;
        List<string> elementos = new List<string>();

        public ListaOrdenada()
        {
            estrategia = new QuickSort();
            elementos.Add("Juana");
            elementos.Add("Albertina");
            elementos.Add("Josefa");
            elementos.Add("Veronica");
            elementos.Add("Mara");
        }

        public void EstableceEstrategia(Ordenamiento est)
        {
            estrategia = est;
        }

        public void Ordena()
        {
            estrategia.Ordena(elementos);
        }
    }
}
