using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Iteradores
{
    interface ILista<T>
    {
        IIterador<T> crearIterador();
        void Adiciona(T e);
        void Elimina(T e);
    }
}
