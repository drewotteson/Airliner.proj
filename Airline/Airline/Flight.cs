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
        public string assignedSeat;
        public string destination;
        public int flightNumber;
        public string origin;
        public int pricePerSeat;

        public Flight(int flightNumber, string origin, string destination)
        {

        }

        public void AddNameToManifest(string name)
        {
            manifest.Add(name);
        }
    }
}
