using System;

namespace Zoo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pet obj  // Overriden by
            Pet animal_1 = new Cat();
            Pet animal_2 = new Dog();
            
            animal_1.readCollar();
            animal_1.communicate();

            animal_2.readCollar();
            animal_2.communicate();

        }
    }
}
