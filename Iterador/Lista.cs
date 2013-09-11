using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteradores
{
    class Lista <T> : ILista<T>
    {
        List<T> elementos = new List<T>();

        public T this[int index] {
            get {
                return elementos.ElementAt(index);
            }
        }

        public int Count
        {
            get {
                return elementos.Count;
            }
        }

        public IIterador<T> crearIterador()
        {
            return new Iterador<T>(this);
        }

        public void Adiciona(T e)
        {
            elementos.Add(e);
        }

        public void Elimina(T e)
        {
            elementos.Remove(e);
        }

    }
}
