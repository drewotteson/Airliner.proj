using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Passenger
    {
        int age;
        string name;
        int money;
        Flight flight;

        public Passenger(string name, int age, int money, Flight flight)
        {
            this.name = name;
            this.age = age;
            this.money = money;
            this.flight = flight;
        }
        public void BuyTicket()
        {
            //reduce their money, and assign them a seat from the array/add to manifest.
        }
    }
}
