using System;

namespace myChallenge
{
    class Passenger : Human
    {
        private string seat;
        
        public Passenger(string name = "Passenger", int age = 0, string nationality = "Unknown", string seat = "A1")
        {
            this.name = name;
            this.age = age;
            this.nationality = nationality;
            this.seat = seat;
        }

        public string getName() {
            return this.name;
        }
        public int getAge() {
            return this.age;
        }
        public string getNationality() {
            return this.nationality;
        }
        public string getSeat() {
            return this.seat;
        }
    }
}
