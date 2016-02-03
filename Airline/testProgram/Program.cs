using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline;

namespace testProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Schedule schedule = new Schedule();
            schedule.chooseCity();
            //Passenger Drew = new Passenger("Drew", 22, 90);
            //Manifest manifest = new Manifest();
            //manifest.AddNameToManifest(Drew);
            //Console.WriteLine(Drew.name);
            //Console.WriteLine(manifest.passengerList[0].name);


        }
        //static void PrintManifest(List<Passenger> PassengerList)
        //{
        //    foreach(Passenger passenger in PassengerList)
        //    {
        //        Console.WriteLine(passenger);
        //    }

        //}
    }
}
