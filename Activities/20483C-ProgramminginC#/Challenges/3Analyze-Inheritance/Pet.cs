using System;

namespace Zoo
{
    // Derived class
    abstract class Pet : Animal
    {
        protected string name;
        protected string owner;

        public void readCollar() {
            Console.WriteLine("My name is {0} and my owner is {1}", this.name, this.owner);
        }

        public abstract void communicate();            
    }
}