using System;
using System.Linq;
using System.Collections.Generic;

namespace T04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, decimal grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public decimal Grade { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            int countOfStudents = int.Parse(Console.ReadLine());
            for (int i = 1; i <= countOfStudents; i++)
            {
                string information = Console.ReadLine();
                string[] arguments = information.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = arguments[0];
                string lastName = arguments[1];
                decimal grade = decimal.Parse(arguments[2]);
                Student newStudent = new Student(firstName, lastName, grade);
                students.Add(newStudent);
            }

            List<Student> sortedStudents = students.OrderByDescending(x => x.Grade).ToList();
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}: {student.Grade}");
            }
        }
    }
}
