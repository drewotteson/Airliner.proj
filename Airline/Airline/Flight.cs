using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Flight 
    {
        public string destination;
        public int flightNumber;
        public string origin;
        public int pricePerSeat;
        Manifest manifest;
        public Flight(Aircraft aircraft, Manifest manifest, int flightNumber, string origin, string destination)
        {

        }
    }
}
