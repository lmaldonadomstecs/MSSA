using System;
using System.IO;

namespace Challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\fmt_9\source\repos\Challenge6\Challenge6\tacos.txt";

            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("No");
                    sw.WriteLine("More");
                    sw.WriteLine("Tacos");
                }
            }

            using (StreamReader sr = File.OpenText(path))
            {
                string s;
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}