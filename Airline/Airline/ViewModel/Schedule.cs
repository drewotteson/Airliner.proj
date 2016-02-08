using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Schedule
    {
        public List<string> mainList = new List<string> { "Chicago", "Detroit", "New York", "Las Vegas" };
        public List<string> subList = new List<string> { "Depart 6:00am Arrive 8:00am", "Depart 7:00am Arrive 9:00am", "Depart 10:00am Arrive 2:00pm", "Depart 6:00 am Arrive 1:00pm" };

        private string _flightCity;
        private string _flightTime;
        private string _flightID;

        public Schedule(string flightCity)
        {
            this._flightCity = flightCity;
            this._flightID = (flightCity);
        }
        public Schedule()
        {

        }
        public override string ToString()
        {
            return _flightID;
        }

        public string seatID
        {
            get
            {
                return _flightCity;
            }
        }

        public List<Schedule> AllFlights()
        {
            List<Schedule> FlightList = new List<Schedule>();
            for (int x = 0; x < mainList.Count; x++)
            {
                //for (int y = 0; y < subList.Count; y++)
                //{
                FlightList.Add(new Schedule(mainList[x]));
                
            }
            return FlightList;
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



