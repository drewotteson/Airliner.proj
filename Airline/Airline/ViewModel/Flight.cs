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
        Aircraft aircraft;
        public Flight(Aircraft aircraft, Manifest manifest, int flightNumber, string origin, string destination)
        {
            this.aircraft = aircraft;
            this.manifest = manifest;
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
        }

    }
}
