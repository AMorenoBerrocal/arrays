using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace array
{
    public class BusRoute
    {
        public int Number { get; }
        public string Origin => PlaceServer[0];
        public string Destination => PlaceServer[1];

        public string[] PlaceServer { get; }

        public BusRoute(int number, string[] placesServed)
        {
            this.Number = number;
            this.PlaceServer = placesServed;
        }
        public override string ToString() => $"{Number}: {Origin} -> {Destination}";

        public bool Serves(string destination)
        {
            return Array.Exists(PlaceServer,  place => place == destination); ;
            /*foreach (string place in PlacesServed)
            {
                if (place == destination)
                {
                    return true;
                }
            }
            return false;*/
        }

        public static List<BusRoute> InitializateRoutes()
        {
            List<BusRoute> result = new List<BusRoute>();
            result.Add(new BusRoute(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" }));
            result.Add(new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" }));
            result.Add(new BusRoute(1_00, new string[] { "Test origin", "Test destination" }));
            result.Add(new BusRoute(5, new string[] { "Overton", "Morecamba", "Carnforth" }));
            return result;
        }

        public static Dictionary<int, BusRoute> InitializateRoutesDict()
        {
            var listaBuses = new Dictionary<int, BusRoute>();
            BusRoute ruta40 = new BusRoute(40, new string[] { "Morecambe", "Lancaster", "Garstang", "Preston" });
            BusRoute ruta42 = new BusRoute(42, new string[] { "Lancaster", "Garstang", "Blackpool" });
            BusRoute ruta1_00 = new BusRoute(1_00, new string[] { "Test origin", "Test destination" });
            BusRoute ruta5 = new BusRoute(5, new string[] { "Overton", "Morecamba", "Carnforth" });

            listaBuses.Add(40, ruta40);
            listaBuses.Add(42, ruta42);
            listaBuses.Add(1_00, ruta1_00);
            listaBuses.Add(5, ruta5);

            return listaBuses;
            
        }
    }
}
