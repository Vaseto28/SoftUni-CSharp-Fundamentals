using System;

namespace _08.Triangle_of_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int rows = 1; rows <= n; rows++)
            {
                for (int columns = 1; columns <= rows; columns++)
                {
                    Console.Write($"{rows} ");
                }
                Console.WriteLine();
            }
        }
    }
}
