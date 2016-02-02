using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Aircraft
    {
        public bool isOperational;
        int availableSeats;
        public int travelMiles;
        Schedule schedule = new Schedule();

        public Aircraft(int availableSeats, int travelMiles, bool isOperational, Schedule schedule)
        {
            this.availableSeats = 100;
            this.travelMiles = travelMiles;
            this.isOperational = isOperational;
            this.schedule = schedule;
        }
    }
}
