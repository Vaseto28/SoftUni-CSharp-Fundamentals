using System;
using System.Collections.Generic;

namespace T06.Courses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> courses = new Dictionary<string, List<string>>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] data = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string courseName = data[0];
                string coursistName = data[1];

                if (courses.ContainsKey(courseName))
                {
                    courses[courseName].Add(coursistName);
                }
                else
                {
                    courses.Add(courseName, new List<string>());
                    courses[courseName].Add(coursistName);
                }
            }

            foreach (var course in courses)
            {
                Console.WriteLine($"{course.Key}: {course.Value.Count}");
                foreach (var coursist in course.Value)
                {
                    Console.WriteLine($"-- {coursist}");
                }
            }
        }
    }
}
