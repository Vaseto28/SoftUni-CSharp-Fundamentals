using System;

namespace _04.Centuries_to_minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            var centuries = short.Parse(Console.ReadLine());
            var years = (int)(centuries * 100);
            var days = (long)(years * 365.2422);
            var hours = (long)(days * 24);
            var minutes = (long)(hours * 60);
            Console.WriteLine($"{centuries} centuries = {years} years = {days} days = {hours} hours = {minutes} minutes");
        }
    }
}
