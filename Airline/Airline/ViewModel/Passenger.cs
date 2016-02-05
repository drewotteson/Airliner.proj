using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Passenger
    {
        public string age;
        public string name;
        public int money;
        public int seat;

        public Passenger(string name, string age, int money)
        {

            this.name = name;
            this.age = age;
            this.money = money;
            this.seat = seat;
        }
        public string getUserName()
        {
            Console.WriteLine("Please enter your first & last name.");
            name = Console.ReadLine();
            return name;
        }
        public string getUserAge()
        {
            Console.WriteLine("Enter your date of birth. 00/00/00");
            age = Console.ReadLine();
            return age;
        }
        public void BuySeat()
        {
            //Nick is currently doing
            //reduce their money, and assign them a seat from the array/add to manifest.
        }
    }
}
