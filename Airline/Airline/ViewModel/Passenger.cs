using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline
{
    public class Passenger
    {
        private string age;
        private string name;

        public Passenger()
        {

        }
        public string getUserName
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string getUserAge
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
    }
}
