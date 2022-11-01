using System;

namespace Т10.Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var m = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());
            var counter = 0;
            var startingN = n;
            while (n >= m)
            {
                n -= m;
                counter++;
                if ((decimal)(0.5 * startingN) == n)
                {
                    if (n / y != 0)
                    {
                        n /= y;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(counter);
        }
    }
}
