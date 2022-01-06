using System;
using System.Collections;

namespace challenge3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList myList = new ArrayList()
            {
                    "Hello",
                    "Some phrase",
                    "Numbers and Letters",
                    5,
                    6,
                    true,
                    false,
                    'a',
                    "Another element"
            };

            Console.WriteLine("My ArrayList");
            Console.WriteLine(" Count: {0}", myList.Count);
            Console.WriteLine(" Capacity: {0}", myList.Capacity);
            Console.Write(" Values:");
            PrintValues(myList);
            Console.ReadKey();
            Console.Clear();
            bool flag;
            Console.WriteLine("Add an element to the arraylist:");
            do
            {
                flag = false;
                Console.Write("New element: ");
                myList.Add(Console.ReadLine());

                Console.WriteLine("Would you like to add another element to the array?");
                string answer = Console.ReadLine();
                if(answer == "yes")
                {
                    flag = true;
                }
            } while (flag);
            PrintValues(myList);
        }
        public static void PrintValues(IEnumerable myList)
        {
            foreach (Object obj in myList)
                Console.WriteLine(" {0}", obj);
        }
    }
}
