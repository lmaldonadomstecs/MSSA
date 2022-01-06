using System;

namespace challenge_5
{
    class Program
    {
        static void Main(string[] args)
        {

            B obj = new B();
            Console.WriteLine(obj.getSum());
            Console.ReadKey();

            Console.Clear();
            Console.WriteLine("Hierarchical inheritance");
            B obj1 = new B();
            C obj2 = new C();
            Console.WriteLine("Using class B object (obj1)");
            Console.WriteLine("a = {0}", obj1.getA());
            Console.WriteLine("b = {0}", obj1.b);
            Console.WriteLine("Using class C object (obj2)");
            Console.WriteLine("a = {0}", obj2.getA());
            Console.WriteLine("c = {0}", obj2.c);
        }
    }
}
