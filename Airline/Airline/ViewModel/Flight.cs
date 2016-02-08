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
        string departureTime;
        string arivalTime;

        public Flight(Aircraft aircraft, Manifest manifest, int flightNumber, string origin, string destination, string arivaltime, string departuretime)
        {
            this.aircraft = aircraft;
            this.manifest = manifest;
            this.flightNumber = flightNumber;
            this.origin = origin;
            this.destination = destination;
            this.arivalTime = arivaltime;
            this.departureTime = departuretime;
        }
        public string DepartureTime
        {
            get
            {
                return departureTime;
            }
        }
        public string ArivalTime
        {
            get
            {
                return arivalTime;
            }
        }

    }
}
