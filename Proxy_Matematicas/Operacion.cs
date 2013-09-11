using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy_Matematicas
{
    interface Operacion
    {
        double Suma(double a, double b);
        double Resta(double a, double b);
        double Mult(double a, double b);
        double Div(double a, double b);
    }
}
