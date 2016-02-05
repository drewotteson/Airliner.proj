using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class DataBase
    {
        Passenger passenger = new Passenger("Breezy", "32", 1000);
        Seat seat = new Seat();
        Manifest manifest = new Manifest();
        Aircraft aircraft = new Aircraft(100, 1000, true);


    }
}
