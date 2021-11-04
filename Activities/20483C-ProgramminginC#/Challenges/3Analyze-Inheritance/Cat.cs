using System;

namespace Zoo
{
    // Derived class
    class Cat : Pet
    {
        public Cat (string voice = "meow", string name = "Garfield", string owner = "John") {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
        }

        public override void communicate() {
            Console.WriteLine(this.voice);
        }
    }
}