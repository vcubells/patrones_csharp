using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoReinoAnimal_AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Africa fabrica1 = new Africa();
            ReinoAnimal reino = new ReinoAnimal(fabrica1);
            reino.Banquete();

            Oceania fabrica2 = new Oceania();
            ReinoAnimal reino2 = new ReinoAnimal(fabrica2);
            reino2.Banquete();

            Console.ReadKey();
        }
    }
}
