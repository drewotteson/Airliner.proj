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
        public List<string> availableSeats;
        public int travelMiles;
        Schedule schedule = new Schedule();

        public Aircraft(List<string> availableSeats, int travelMiles, bool isOperational, Schedule schedule)
        {
            this.availableSeats = availableSeats;
            this.travelMiles = travelMiles;
            this.isOperational = isOperational;
            this.schedule = schedule;
        }
    }
}
