using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Schedule
    {
        public int departureTime;
        public int arrivalTime;
        public string city;

        Dictionary<string, string> AirlineSchedule;
        List<string> keyList;
       
         
        public Schedule()
        {
            Dictionary<string, string> AirlineSchedule = new Dictionary<string, string>();
            AirlineSchedule.Add("Chicago", "Departure: , Arrival");
            AirlineSchedule.Add("Detroit", "Departure, Arrival");
            AirlineSchedule.Add("Minneapolis", "Departure, Arrival");
            AirlineSchedule.Add("Indianapolis", "Departure, Arrival");
            AirlineSchedule.Add("New York", "Departure, Arrival");
            AirlineSchedule.Add("Boston", "Departure, Arrival");
            AirlineSchedule.Add("Cleveland", "Departure, Arrival");
            AirlineSchedule.Add("Philadelphia", "Departure, Arrival");
            AirlineSchedule.Add("Baltimore", "Departure, Arrival");
            AirlineSchedule.Add("Washington D.C.", "Departure, Arrival");
            AirlineSchedule.Add("Atlanta", "Departure, Arrival");
            AirlineSchedule.Add("Houston", "Departure, Arrival");
            AirlineSchedule.Add("Denver", "Departure, Arrival");
            AirlineSchedule.Add("Seattle", "Departure, Arrival");
            AirlineSchedule.Add("San Francisco", "Departure, Arrival");

            List<string> keyList = new List<string>(this.AirlineSchedule.Keys);
            
            }

        }
        
    }

