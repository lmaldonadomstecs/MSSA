using System;

namespace School
{
    class Student
    {
        // Fields
        private int id;

        // Constructor
        public Student (ref int student) {
            student++;
            this.id = student;
        }
    }
}
