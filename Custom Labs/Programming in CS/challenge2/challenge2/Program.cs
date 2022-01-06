using System;

namespace challenge2
{
    class Program
    {
        static void Main(string[] args)
        {
            // First
            int[] array = new int[5] { 1, 4, 2, 3, 5 };
            Console.WriteLine("---Default Array Elements---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Array.Sort(array);
            Console.WriteLine("---Elements after sort---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Array.Reverse(array);
            Console.WriteLine("---Elements after sort---");
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Press Enter Key to Continue..");
            Console.ReadLine();

            // Second
            Console.Clear();
            int[] arr = new int[10];
            int j;

            Console.Write("Module02: Sort items into an array\n");
            Console.Write("-----------------------------------------\n");
            Console.Write("Input 10 elements in the array :\n");

            for (j = 0; j < arr.Length; j++)
            {
                Console.Write("element - {0} : ", j);
                arr[j] = Convert.ToInt32(Console.ReadLine());
            }


            Console.Write("\nElements in array are: ");
            for (j = 0; j < arr.Length; j++)
            {
                Console.Write("{0} ", arr[j]);
            }
            Console.Write("\n");


            Console.WriteLine("Press Enter Key to Continue..");
            Console.ReadLine();

            string[] names = { "John", "Jane", "Michael", "George" };
            int k;

            Console.WriteLine("Full list of names");
            for (k = 0; k < names.Length; k++)
            {
                Console.WriteLine("{0} ", names[k]);
            }
            Console.Write("\n");

            Console.WriteLine("Second element on the list: {0}", names[1]);

            bool flag = false;
            do
            {
                Console.WriteLine("What name are you looking for in the array?");
                string someName = Console.ReadLine();
                Console.WriteLine(getName(someName, names));

                Console.WriteLine("Wanna look for another name?");
                string answer = Console.ReadLine();
                if (answer == "yes" || answer == "y")
                {
                    flag = true;
                }
            } while (flag);



        }

        public static string getName(string searchName, string[] names)
        {
                foreach (string name in names)
                {
                    if (name == searchName)
                    {
                        return name;
                    }
                }
                return $"No {searchName} was found in the array";
        }
    }
}
