using System;

namespace m3
{
    struct Donut {
        private float diameter;
        public string flavor { get; set; }
        private bool vegan;

        public Donut(float diameter, string flavor, bool vegan) {
            this.diameter = diameter;
            this.flavor = flavor;
            this.vegan = vegan;
        }

        public string Flavor {
            get { return flavor; }
            set { flavor = value; }
        }
    }

    struct Menu {
        public string[] beverages;

        public Menu (string[] beverages) {
            this.beverages = beverages;
        }

        // INDEXER
        public string this[int index] {
            get { return this.beverages[index]; }
            set { this.beverages[index] = value; }
        }
    }
    class Program
    {
        public static void Main() {
            Donut x = new Donut();
            // Donut x;
            x.flavor = "Chocolate";
            
            Console.WriteLine(x.flavor);
            string[] payload = { "Milkshake", "Chocomilk", "Strawberry shake", "Beer" };
            Menu menu = new Menu(payload);

            Console.WriteLine(menu[1]);
        }       
    }
}