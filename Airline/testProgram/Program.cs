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
            schedule.AllFlights();
            Console.ReadLine();

            //Passenger Drew = new Passenger("Drew", 22, 90);
            //Manifest manifest = new Manifest();
            //manifest.AddNameToManifest(Drew);
            //Console.WriteLine(Drew.name);

            //Schedule schedule = new Schedule();
            //schedule.chooseCity();

            //Passenger Drew = new Passenger("Drew", 22, 90);
            //Manifest manifest = new Manifest();
            //manifest.AddNameToManifest(Drew);
            //Console.WriteLine(Drew.name);

            //Console.WriteLine(manifest.passengerList[0].name);

            //Console.WriteLine(manifest.GetPassengerList().ToString());

            //Aircraft aircraft = new Aircraft(100, 1000, true);
            //aircraft.AssignSeat();
            //Console.ReadLine();

            //Aircraft aircraft = new Aircraft(100, 1000, true);
            //aircraft.AssignSeat();
            //Console.ReadLine();



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
