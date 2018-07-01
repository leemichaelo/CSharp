using System;
using System.Collections.Generic;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };

            students.Sort();

            Student newStudent = new Student()
            {
                Name = "Joe",
                GradeLevel = 2
            };

            int index = students.BinarySearch(newStudent);

            if(index < 0)
            {
                //the ~ is a bit wise operater and is the same as making index -
                students.Insert(~index - 1, newStudent);
            }

            foreach(Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
        }
    }
}
