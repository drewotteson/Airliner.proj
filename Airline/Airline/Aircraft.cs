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
        public int availableSeats;
        public int travelMiles;
        Schedule schedule = new Schedule();

        public Aircraft(int availableSeats, int travelMiles, bool isOperational/*, Schedule schedule*/)
        {
            this.availableSeats = availableSeats;
            this.travelMiles = travelMiles;
            this.isOperational = isOperational;
            //this.schedule = schedule;
        }
        public int AssignSeat()
        {
            availableSeats -= 1;
            return availableSeats;
        }
    }
}
