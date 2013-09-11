using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Computadoras_Builder
{
    class Computadora
    {
        private Dictionary<string, string> partes = new Dictionary<string, string>();

        public string get(string key)
        { 
            return partes[key];
        }

        public void set(string key, string value)
        {
            partes.Add(key, value);
        }

        public void Mostrar()
        {
            Console.WriteLine("Partes de la computadora: ");
            foreach (KeyValuePair<string, string> t in partes)
            {
                Console.WriteLine("{0} -> {1}", t.Key, t.Value);
            }
        }
    }
}
