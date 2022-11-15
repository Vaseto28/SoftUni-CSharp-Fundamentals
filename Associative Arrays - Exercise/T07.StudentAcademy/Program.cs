using System;
using System.Collections.Generic;

namespace T07.StudentAcademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();
            int studentsGrades = int.Parse(Console.ReadLine());

            for (int i = 1; i <= studentsGrades; i++)
            {
                string studentName = Console.ReadLine();
                double grade = double.Parse(Console.ReadLine());

                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(grade);
                    continue;
                }

                students.Add(studentName, new List<double> { grade });
            }

            foreach (var student in students)
            {
                double totalSumGrades = 0.0;
                for (int i = 0; i < student.Value.Count; i++)
                {
                    totalSumGrades += student.Value[i];
                }

                double averageGrade = totalSumGrades / student.Value.Count;
                if (averageGrade >= 4.50)
                {
                    Console.WriteLine($"{student.Key} -> {averageGrade:f2}");
                }
            }
        }
    }
}
