using System;

namespace Zoo
{
    // Derived class
    class Dog : Pet
    {
        public Dog (string voice = "woof", string name = "Odie", string owner = "John") {
            this.voice = voice;
            this.name = name;
            this.owner = owner;
        }

        public override void communicate() {
            Console.WriteLine(this.voice);
        }
    }
}