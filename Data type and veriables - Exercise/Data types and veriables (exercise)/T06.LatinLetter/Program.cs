using System;

namespace T06.LatinLetter
{
    class Program
    {
        static void Main(string[] args)
        {
            var letters = int.Parse(Console.ReadLine());
            for (int i = 0; i < letters; i++)
            {
                for (int j = 0; j < letters; j++)
                {
                    for (int k = 0; k < letters; k++)
                    {
                        var firstChar = (char)('a' + i);
                        var secondChar = (char)('a' + j);
                        var thirdChar = (char)('a' + k);
                        Console.WriteLine($"{firstChar}{secondChar}{thirdChar}");
                    }
                }
            }
        }
    }
}
