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
        

        public Dictionary<string, string> AirlineSchedule;
        //List<string> keyList;

        public string chooseCity()
        {
            Dictionary<string, string> AirlineSchedule = new Dictionary<string, string>();

            AirlineSchedule.Add("Chicago 200", "Departure 6:00am/Arrival 8:00am");
            AirlineSchedule.Add("Detroit 210", "Departure 5:00am/Arrival 9:00am");
            AirlineSchedule.Add("Minneapolis 220", "Departure 7:00am/Arrival 11:00am");
            AirlineSchedule.Add("Indianapolis 230", "Departure 1:00pm/Arrival 4:00pm");
            AirlineSchedule.Add("New York 240", "Departure 7:00am/Arrival 2:00pm");
            AirlineSchedule.Add("Boston 250", "Departure 8:00am/Arrival 4:00pm");
            AirlineSchedule.Add("Cleveland 260", "Departure 5:00am/Arrival 11:00am");
            AirlineSchedule.Add("Philadelphia 270", "Departure 6:00am/Arrival 1:00pm");
            AirlineSchedule.Add("Baltimore 280", "Departure 7:00am/Arrival 2:00pm");
            AirlineSchedule.Add("Washington D.C. 290", "Departure 6:00am/Arrival 3:00pm");
            AirlineSchedule.Add("Atlanta 300", "Departure 2:00pm/Arrival 9:00pm");
            AirlineSchedule.Add("Houston 310", "Departure 1:00pm/Arrival 11:30pm");
            AirlineSchedule.Add("Denver 320", "Departure 8:00am/Arrival 3:00pm");
            AirlineSchedule.Add("Seattle 330", "Departure 7:00am/Arrival 4:30pm");
            AirlineSchedule.Add("San Francisco 340", "Departure 6:00am/Arrival 4:00pm");

            foreach (KeyValuePair<string, string> city in AirlineSchedule)
            {
                return (city.Key + " : " + city.Value);
            }

            return city;
        }
    }
}





//public Schedule()
//{



//    List<string> keyList = new List<string>(this.AirlineSchedule.Keys);

//}
//public void DisplayCity()
//{

//}



