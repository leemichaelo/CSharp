using System;
using System.Collections.Generic;

namespace CSharpCollections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Student> students = new HashSet<Student>
            {
                new Student() { Name = "Sally", GradeLevel = 3 },
                new Student() { Name = "Bob", GradeLevel = 3 },
                new Student() { Name = "Sally", GradeLevel = 2 }
            };

            Student joe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(joe);

            Student duplicateJoe = new Student() { Name = "Joe", GradeLevel = 2 };
            students.Add(duplicateJoe);

            if (students.Contains(joe))
            {

            }

            foreach (Student student in students)
            {
                Console.WriteLine($"{student.Name} is in grade {student.GradeLevel}");
            }
        }
    }
}
