using System;

namespace example
{
    class Program
    {
        static void Main(string[] args)
        {
            Human h_mx_l = new Human("Leon", "Maldonado", 25);

            Console.WriteLine($"New human's name: {h_mx_l.first_name}");

            // Get human's favorite number in 2 lines of code
            h_mx_l.favoriteNumber(out int number);
            Console.WriteLine(number);

            // Create a food variable with any value and send it to a favoriteFood method and then print the human's favorite food
            string food = "Hamburguers";
            h_mx_l.favoriteFood(ref food);
            Console.WriteLine($"{h_mx_l.first_name}'s favorite food is: {food}");

            // Create a boolean variable named closed_love_letter and send it to a openLoveLetter method, but don't allow the human to change the boolean value to false (to open the letter)
            bool closed_love_letter = true;
            h_mx_l.openLoveLetter(in closed_love_letter);
        }
    }
}
