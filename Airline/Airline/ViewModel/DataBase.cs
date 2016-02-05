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
        public DataBase()
        {
            this._seatList = seat.AllSeats();
        }
        public List<Seat> seatList
        {
            get
            {
                return _seatList;
            }
        }

    }
}
