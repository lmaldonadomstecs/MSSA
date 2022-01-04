using System;
using System.Collections.Generic;

namespace myChallenge
{
    class Program
    {
            
        static void Main(string[] args)
        {
            Airplane airplane = new Airplane();
            

            Console.WriteLine(airplane.availableSeats());
            Console.WriteLine(airplane.totalOfPassengers());
            airplane.printListOfPassengers();
            Console.WriteLine("Origin: " + airplane.checkNextFlight().origin + "\nDestination:" + airplane.checkNextFlight().destination);
        }
    }
}
