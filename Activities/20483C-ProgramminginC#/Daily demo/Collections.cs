using System;
using System.Collections;

namespace collections
{
    class Kitty {
        string name = "boris";
    }
    class Coffee {
        Kitty boris = new Kitty();
        #region fields
        public string name;
        #endregion

        #region methods
        public Coffee (string name) {
            this.name = name;
            // Subscribers
            // onTrigger += subscriber1;
            // onTrigger += subscriber2;
            // onTrigger += subscriber3;
            // onTrigger += subscriber4;
            // onTrigger += subscriber5;
            // onTrigger += subscriber6;
        }
        #endregion

        #region event
        public delegate void CustomEventHandler();


        // New event created
        private event CustomEventHandler onTrigger;

        // Trigger
        public void trigger() {
            onTrigger?.Invoke();
        }

        // The function that the subscriber performs
        public void subscriber1() {
            Console.WriteLine("Subscriber 1 was executed by event.");
        }
        public void subscriber2() {
            Console.WriteLine("Subscriber 2 was executed by event.");
        }
        public void subscriber3() {
            Console.WriteLine("Subscriber 3 was executed by event.");
        }
        public void subscriber4() {
            Console.WriteLine("Subscriber 4 was executed by event.");
        }
        public void subscriber5() {
            Console.WriteLine("Subscriber 5 was executed by event.");
        }
        public void subscriber6() {
            Console.WriteLine("Subscriber 6 was executed by event.");
        }
        #endregion


    }
    class example
    {
        public void exmain()
        {
            Coffee coffee = new Coffee("Mexican Coffee");
            coffee.trigger();

            Coffee coffee1 = new Coffee("Mexican Coffee");
            Coffee coffee2 = new Coffee("Mexican Coffee");
            Coffee coffee3 = new Coffee("Mexican Coffee");
            ArrayList obj = new ArrayList();

            obj.Add(coffee);
            obj.Add(coffee1);
            obj.Add(coffee2);
            obj.Add(coffee3);

            Console.WriteLine(obj[3]);


            Coffee[] newCoffee = {coffee, coffee1, coffee2, coffee3};
            Console.WriteLine(newCoffee[3].name);

            

            Hashtable htable = new Hashtable();
            htable.Add("Hello", "How are you");
            htable.Add("Whatever", "Princess");

            Console.WriteLine(htable["Whatever"]);
        }
    }
}
