using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Schedule
    {
        public int DepartureTime;
        public int ArrivalTime;
        public string City;
        Dictionary<string, string> AirlineSchedule = new Dictionary<string, string>()
        {
            {"Chicago", "Departure" },
            {"Detroit", "Departure" },

        };
         
        public Schedule()
        {

        }
        
    }
}
