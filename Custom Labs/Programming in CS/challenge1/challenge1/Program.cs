using System;

namespace challenge1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Another way to declare variables.
            double firstNum, secondNum, sum;

            Console.Write("Introduce first number: ");
            firstNum = getEvenNum();

            Console.Write("Introduce second number: ");
            secondNum = getEvenNum();

            sum = firstNum + secondNum;

            Console.WriteLine("The sum of {0} and {1} is {2}", firstNum, secondNum, sum);
        }

        public static double getEvenNum()
        {
            // 2 / 2 = 1
            // if 2 % 2 = 0 then even
            double num = Convert.ToDouble(Console.ReadLine());
            if (num % 2 == 0)
            {
                return num;
            }
            else
            {
                Console.WriteLine("Please input an even number.");
                return getEvenNum();
            }
        }
    }
}
