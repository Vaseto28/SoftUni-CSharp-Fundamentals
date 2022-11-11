using System;
using System.Collections.Generic;

namespace T04.Students
{
    class Student
    {
        public Student(string firstName, string lastName, int age, string hometown)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Hometown = hometown;
        }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Age { get; set; }

        public string Hometown { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string firstName = arguments[0];
                string lastName = arguments[1];
                int age = int.Parse(arguments[2]);
                string hometown = arguments[3];

                Student newStudent = new Student(firstName, lastName, age, hometown);
                students.Add(newStudent);
            }

            string hometownToSearch = Console.ReadLine();
            foreach (var student in students)
            {
                if (student.Hometown == hometownToSearch)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
}
