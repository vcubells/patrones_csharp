using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Singleton
{
    class LoadBalancer
    {
        private static LoadBalancer instance = null;
        static List<String> servers = new List<String>();
        private static Random ran = new Random();

        protected LoadBalancer() 
        {
            servers.Add("Server 1");
            servers.Add("Server 2");
            servers.Add("Server 3");
            servers.Add("Server 4"); 
            servers.Add("Server 5");
            servers.Add("Server 6");
        }

        public static LoadBalancer GetInstance()
        {          
            if (instance == null)
            {
                instance = new LoadBalancer();
            }
            int server = ran.Next(0, 5);
            Console.WriteLine("Se asigno la solicitud al server {0}", servers[server]);
            return instance;
        }
    }

    
    class Program
    {
        static void Main(string[] args)
        {
            LoadBalancer o1 = LoadBalancer.GetInstance();
            LoadBalancer o2 = LoadBalancer.GetInstance();
            LoadBalancer o3 = LoadBalancer.GetInstance();
            LoadBalancer o4 = LoadBalancer.GetInstance();

            Console.ReadKey();
        }
    }
}
