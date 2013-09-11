using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Observador_INversionista
{
    class Bolsa
    {
        List<Inversionista> inversionistas = new List<Inversionista>();
        float accion = 1;

        public float Accion
        {
            get { return accion; }

            set
            {
                if (accion != value)
                {
                    accion = value;
                    Notificar();
                }
            }
        }

        public void Registrar(Inversionista i)
        {
            inversionistas.Add(i);
        }

        public void Expulsar(Inversionista i)
        {
            inversionistas.Remove(i);
        }

        public void Notificar()
        {
            foreach (Inversionista i in inversionistas)
            {
                i.Actualiza(this);
            }
        }
    }
}
