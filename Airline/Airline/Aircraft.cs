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

        public Aircraft(int availableSeats, int travelMiles, bool isOperational, Schedule schedule)
        {

        }
    }
}
