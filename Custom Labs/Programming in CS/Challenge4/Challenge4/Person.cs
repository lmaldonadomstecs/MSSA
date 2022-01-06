using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenge4
{
    class Person
    {
        // Attributes
        public string Name { get; set; }

        // Constructor
        public Person(string name)
        {
            Name = name;
        }

        //Method
        public string ToString()
        {
            return "Hello! My name is " + Name;
        }

        // IDisposable
        // Destructor
        ~Person()
        {
            Name = string.Empty;
        }
    }
}
