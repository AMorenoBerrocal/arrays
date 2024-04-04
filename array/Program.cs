using array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    class Program
    {
        static void Main(string[] args)
        {
            BusRoute route40 = new BusRoute(40, "Moorecambe", "Preston");
            BusRoute route42 = new BusRoute(42, "Lancaster", "Blackpool");

            BusRoute[] routes = { route40, route42, new BusRoute(100, "University", "Morecambe"), new BusRoute(555, "Lancaster", "Kswick") };

            BusRoute firsRoute = routes[0];
            Console.WriteLine("Primera ruta: " + routes[0]);

            Console.WriteLine("Recorremos las rutas con un foreach: ");

            foreach (BusRoute route in routes)
            {
                Console.WriteLine(route);
            }

            Console.WriteLine("Recorremos las rutas con un for: ");
            for (int i = 0; i < routes.Length; i++)
            {
                Console.WriteLine(routes[i]);
            }

            BusRoute[] rutas = new BusRoute[4];

            for (int i = 0; i < rutas.Length; i++)
            {
                Console.WriteLine(rutas[i]);
            }

            rutas[0] = routes[0];
            rutas[1] = routes[1];
            rutas[2] = routes[2];
            rutas[3] = routes[3];

            Console.WriteLine("Donde quieres ir?");
            string location = Console.ReadLine();

            if(FindBusTo(routes, location)!=null) {
                Console.WriteLine("Hay viaje para ir a " + location);
            } else
            {
                Console.WriteLine("No hay viaje para ir a " + location);
            }

        }

        public static BusRoute FindBusTo(BusRoute[] routes, string location)
        {
            /*foreach(BusRoute route in routes)
            {
                if(route.Origin == location || route.Destination == location)
                {
                    return route;
                }
            }
            return null;*/
            return Array.Find(routes, 
                route => route.Origin == location || route.Destination == location);

        }


    }
}
