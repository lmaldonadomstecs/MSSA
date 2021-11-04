using System;

namespace Zoo
{
    // Derived class
    class Dog : Pet
    {
        private string voice;

        public Dog (string voice = "woof", string name = "Odie", string owner = "John") {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
        }

        public void communicate() {
            Console.WriteLine(this.voice);
        }
    }
}