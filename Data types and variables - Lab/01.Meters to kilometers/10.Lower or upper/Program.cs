using System;

namespace _10.Lower_or_upper
{
    class Program
    {
        static void Main(string[] args)
        {
            var letter = char.Parse(Console.ReadLine());
            if ((int)letter >= 65 && (int)letter <= 90)
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                Console.WriteLine("lower-case");
            }
        }
    }
}
