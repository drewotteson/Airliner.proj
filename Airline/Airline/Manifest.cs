using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Manifest
    {
        public List<Passenger> passengerList;

        public Manifest()
        {
            passengerList = new List<Passenger>();
        }
        public void AddNameToManifest(Passenger passenger)
        {
            passengerList.Add(passenger);
        }
        public List<Passenger> GetPassengerList()
        {
            return passengerList;
        }
    }   

}



