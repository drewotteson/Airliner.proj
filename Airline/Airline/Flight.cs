using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Flight 
    {
        private List<string> manifest;
        public string destination;
        public int flightNumber;
        public string origin;
        public int pricePerSeat;

        public Flight(Aircraft aircraft, int flightNumber, string origin, string destination, List<string> manifest)
        {

        }

        public void AddNameToManifest(string name)
        {
            manifest.Add(name);
        }
    }
}
