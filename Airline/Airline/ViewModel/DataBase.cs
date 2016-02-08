using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class DataBase
    {
        Seat seat = new Seat();
        private List<Seat> _seatList;

        Schedule schedule = new Schedule();
        private List<Schedule> _flightList;

        public DataBase()
        {
            this._seatList = seat.AllSeats();
            this._flightList = schedule.AllFlights();
        }

        public List<Seat> seatList
        {
            get
            {
                return _seatList;
            }
        }

        public List<Schedule> flightList
        {
            get
            {
                return _flightList;
            }
        }


    }
}
