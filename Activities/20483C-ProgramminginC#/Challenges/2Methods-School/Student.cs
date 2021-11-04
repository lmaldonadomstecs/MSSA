using System;

namespace School
{
    class Student
    {
        // Fields
        private int id;

        // Constructor
        public Student (ref int id) {
            id++; // School.students += 1;
            this.id = id;
        }
        ~Student() {
            Console.WriteLine("Student with id {0} destroyed.", this.id);
        }
    }
}
