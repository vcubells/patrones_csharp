using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy_Matematicas
{
    class Proxy : Operacion
    {
        private Basica basica = new Basica();

        public double Suma(double a, double b)
        {
            // Realizar validaciones y/o transformaciones
            return basica.Suma(a, b);
        }

        public double Resta(double a, double b)
        {
            // Realizar validaciones y/o transformaciones
            return basica.Resta(a, b);
        }

        public double Mult(double a, double b)
        {
            // Realizar validaciones y/o transformaciones
            return basica.Mult(a, b);
        }

        public double Div(double a, double b)
        {
            // Realizar validaciones y/o transformaciones
            return basica.Div(a, b);
        }
    }
}
