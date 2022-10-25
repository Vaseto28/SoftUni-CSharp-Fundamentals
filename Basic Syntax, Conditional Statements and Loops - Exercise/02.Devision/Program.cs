using System;

namespace _02.Devision
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            var flag = -1;
            if (num % 10 == 0)
            {
                flag = 10;
            }
            else if (num % 7 == 0)
            {
                flag = 7;
            }
            else if (num % 6 == 0)
            {
                flag = 6;
            }
            else if (num % 3 == 0)
            {
                flag = 3;
            }
            else if (num % 2 == 0)
            {
                flag = 2;
            }

            if (flag == -1)
            {
                Console.WriteLine("Not divisible");
            }
            else
            {
                Console.WriteLine($"The number is divisible by {flag}");
            }
        }
    }
}
