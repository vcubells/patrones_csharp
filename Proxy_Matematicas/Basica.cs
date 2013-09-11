using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy_Matematicas
{
    class Basica : Operacion
    {
        public double Suma(double a, double b)
        {
            return a + b;
        }
        public double Resta(double a, double b)
        {
            return a - b;
        }

        public double Mult(double a, double b)
        {
            return a * b;
        }

        public double Div(double a, double b)
        {
            return a / b;
        }
    }
}
