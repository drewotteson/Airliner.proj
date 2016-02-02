using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Manifest
    {
        List<string> listOfPassengers;
        Passenger passenger = new Passenger("Bobby", 32, 1000);

        public Manifest(Passenger passenger)
        {

        }
        public void AddNameToManifest(string name)
        {
            listOfPassengers.Add(name);
        }
    }

}
