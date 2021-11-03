using System;

namespace example
{
    class Human
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public int age { get; set; }
        public int favorite_number { get; set; }

        public Human (string first_name = "John", string last_name = "Doe", int age = 18, int favorite_number = 7) {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
            this.favorite_number = favorite_number;
        }
        // Create a method to return the human's favorite number
        public void favoriteNumber (out int number) {
            number = this.favorite_number;
            number = 420;
        }

        // Create a favoriteFood method to select that the favorite food is pizza.
        public void favoriteFood (ref string food) {
            if (food.ToLower() != "pizza") {
                food = "pizza";
            }
        }

        // Create a openLoveLetter method that will only receive read only variables. Human won't be able to open letter.
        public void openLoveLetter(in bool closed_love_letter) { }
    }
}
