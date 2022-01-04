using System;
using System.Collections.Generic;

namespace myChallenge
{
    class Airplane
    {
        public string company;
        public List<Passenger> passengers;
        public Queue<Flight> flights;
        public int seats;

        public Airplane(string company = "Generic Airline", int seats = 100) {
            this.company = company;
            this.seats = seats;

            flights = new Queue<Flight>();
            Flight flight_1 = new Flight(origin: "Montreal", destination: "Paris");
            Flight flight_2 = new Flight(origin: "Paris", destination: "Japan");
            Flight flight_3 = new Flight(origin: "Japan", destination: "California");
            Flight flight_4 = new Flight(origin: "California", destination: "Montreal");

            flights.Enqueue(flight_1);
            flights.Enqueue(flight_2);
            flights.Enqueue(flight_3);
            flights.Enqueue(flight_4);


            passengers = new List<Passenger>(){
                new Passenger(name: "John", age: 26, nationality: "American", seat: "A2"),
                new Passenger(name: "Henriette", age: 26, nationality: "German", seat: "A3"),
                new Passenger(name: "Jean", age: 26, nationality: "French", seat: "A4"),
                new Passenger(name: "Yui", age: 26, nationality: "Japanese", seat: "A5")
            };
        }

        public int totalOfSeats() {
            return seats;
        }
        public int availableSeats() {
            int total = seats - passengers.Count;
            return total;
        }

        public int totalOfPassengers() {
            return passengers.Count;
        }

        public void printListOfPassengers() {
            Console.WriteLine("= List of passengers ========");
            foreach(Passenger passenger in passengers) {
                Console.WriteLine(passenger.getName());
                Console.WriteLine(passenger.getAge());
                Console.WriteLine(passenger.getNationality());
                Console.WriteLine(passenger.getSeat());
                Console.WriteLine("=========================");
            }
        }

        public Flight checkNextFlight() {
            return flights.Peek();
        }
    }
}
