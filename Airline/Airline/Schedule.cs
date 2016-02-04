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
        public void CurrentDateAndTime()
        {

        }

        public void chooseCity()
        {
            Dictionary<string, string> AirlineSchedule = new Dictionary<string, string>();

            AirlineSchedule.Add("Chicago 200", "Departure 6:00am, Arrival");
            AirlineSchedule.Add("Detroit 210", "Departure, Arrival");
            AirlineSchedule.Add("Minneapolis 220", "Departure, Arrival");
            AirlineSchedule.Add("Indianapolis 230", "Departure, Arrival");
            AirlineSchedule.Add("New York 240", "Departure, Arrival");
            AirlineSchedule.Add("Boston 250", "Departure, Arrival");
            AirlineSchedule.Add("Cleveland 260", "Departure, Arrival");
            AirlineSchedule.Add("Philadelphia 270", "Departure, Arrival");
            AirlineSchedule.Add("Baltimore 280", "Departure, Arrival");
            AirlineSchedule.Add("Washington D.C. 290", "Departure, Arrival");
            AirlineSchedule.Add("Atlanta 300", "Departure, Arrival");
            AirlineSchedule.Add("Houston 310", "Departure, Arrival");
            AirlineSchedule.Add("Denver 320", "Departure, Arrival");
            AirlineSchedule.Add("Seattle 330", "Departure, Arrival");
            AirlineSchedule.Add("San Francisco 340", "Departure, Arrival");



            foreach (KeyValuePair<string, string> city in AirlineSchedule)
            {
                Console.WriteLine(city.Key + " : " + city.Value);
                Console.Read();

            }

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



