using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proxy_Matematicas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basica opera = new Basica();
            Proxy opera = new Proxy();

            double num1 = 34;
            double num2 = 23.5;

            Console.WriteLine(" a + b = {0}", opera.Suma(num1, num2));
            Console.WriteLine(" a - b = {0}", opera.Resta(num1, num2));
            Console.WriteLine(" a * b = {0}", opera.Mult(num1, num2));
            Console.WriteLine(" a / b = {0}", opera.Div(num1, num2));

            Console.ReadKey();
        }
    }
}
