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

        public Passenger(string name, int age, int money)
        {
            this.name = name;
            this.age = age;
            this.money = money;
        }
        public void BuyTicket()
        {
            //reduce their money, and assign them a seat from the array/add to manifest.
        }
    }
}
