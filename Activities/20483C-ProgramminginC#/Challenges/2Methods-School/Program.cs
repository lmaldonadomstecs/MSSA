using System;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine(School.getStudents());
            Student student_1 = new Student(ref School.students);
            Student student_2 = new Student(ref School.students);
            Student student_3 = new Student(ref School.students);
            Student student_4 = new Student(ref School.students);
            Student student_5 = new Student(ref School.students);
            Console.WriteLine(School.getStudents());
        }
    }
}
