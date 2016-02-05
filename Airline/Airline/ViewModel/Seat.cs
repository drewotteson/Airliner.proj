using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;

namespace Airline
{
    public class Seat
    {
        public List<string> mainList = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        public List<string> subList = new List<string> { "A", "B", "C", "D" };

        private string _seatNumber;
        private string _seatLetter;
        private string _seatID;

        public Seat(string seatNumber, string seatLetter)
        {
            this._seatNumber = seatNumber;
            this._seatLetter = seatLetter;
            this._seatID = (seatNumber.ToString() + seatLetter);
        }
        public Seat()
        {

        }
        public override string ToString()
        {
            return _seatID;
        }

        public string seatID
        {
            get
            {
                return _seatID;
            }
        }

        public List<Seat> AllSeats()
        {
            List<Seat> SeatList = new List<Seat>();
            for (int x=0; x < mainList.Count; x++)
            {
                for (int y=0; y < subList.Count; y++)
                {
                    SeatList.Add(new Seat(mainList[x], subList[y]));
                }
            }
            return SeatList;
        }
    }
}
