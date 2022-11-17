using System;

namespace T03.Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string stringToSubtract = Console.ReadLine();
            string @string = Console.ReadLine();

            while (@string.Contains(stringToSubtract))
            {
                @string = @string.Replace(stringToSubtract, string.Empty);
            }

            Console.WriteLine(@string);
        }
    }
}
