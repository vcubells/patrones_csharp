using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteradores
{
    class Iterador<T> : IIterador<T>
    {
        private int posicion;
        private Lista<T> lista;
        private int paso;

        public Iterador(Lista<T> lista)
        {
            this.lista = lista;
            paso = 1;
        }

        public void Paso(int p)
        {
            paso = p;
        }
        
        public T Inicio()
        {
            posicion = 0;
            return lista[posicion];
        }

        public T Siguiente()
        {
            posicion += paso;
            if (!esFin())
                return lista[posicion];
            else return default(T);
        }

        public bool esFin()
        {
            return posicion >= lista.Count;
        }

        public T Ultimo()
        {
            posicion = lista.Count - 1;
            return lista[posicion];
        }
    }
}
