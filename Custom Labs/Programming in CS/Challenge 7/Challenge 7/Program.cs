using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenge_7
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> integerList = new List<int>()
            {
                1, 2, 3, 4, 5, 6, 7, 8, 9, 10
            };

            var QuerySyntax = from obj in integerList where obj > 5 select obj;

            // select obj from obj in integerList where obj > 5;

            foreach (var item in QuerySyntax)
            {
                Console.Write(item + " ");
            }
            Console.ReadKey();
        }
    }
}
