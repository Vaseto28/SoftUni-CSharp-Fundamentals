using System;

namespace T03.Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = int.Parse(Console.ReadLine());
            var capacity = int.Parse(Console.ReadLine());
            var courses = 0;
            for (int i = people; i > 0; i-=capacity)
            {
                courses++;
            }
            Console.WriteLine(courses);
        }
    }
}
