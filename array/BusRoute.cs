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
    }
}
