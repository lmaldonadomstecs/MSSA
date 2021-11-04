using System;

namespace Zoo
{
    // Derived class
    class Pet : Animal
    {
        protected string name;
        protected string owner;

        public void readCollar() {
            Console.WriteLine("My name is {0} and my owner is {1}", this.name, this.owner);
        }

        public void communicate() {
            Console.WriteLine("Pet is trying to communicate.");
        }
    }
}