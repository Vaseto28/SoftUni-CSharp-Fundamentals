using System;
using System.Linq;
using System.Collections.Generic;

namespace T01.SoftUniReception
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstEmployerEfficency = int.Parse(Console.ReadLine());
            var secondEmployerEfficency = int.Parse(Console.ReadLine());
            var thirdEmployerEfficency = int.Parse(Console.ReadLine());
            var studentsQuestionsCount = int.Parse(Console.ReadLine());

            var allEmployersEfficency = firstEmployerEfficency + secondEmployerEfficency + thirdEmployerEfficency;
            var hours = 0;
            while (studentsQuestionsCount > 0)
            {
                hours++;
                if (hours % 4 == 0)
                {
                    continue;
                }
                else
                {
                    studentsQuestionsCount -= allEmployersEfficency;
                }
            }

            Console.WriteLine($"Time needed: {hours}h.");
        }
    }
}
