using System;
using System.Text;

namespace T07.RepeatStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            var @string = Console.ReadLine();
            var times = int.Parse(Console.ReadLine());
            var outputString = RepeatingString(@string, times);
            Console.WriteLine(outputString);
        }

        static string RepeatingString(string @string, int times)
        {
            StringBuilder builderOfStrings = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                builderOfStrings.Append(@string);
            }

            return builderOfStrings.ToString();
        }



        //Alternative way
        //static void Main(string[] args)
        //{
        //    var @string = Console.ReadLine();
        //    var times = int.Parse(Console.ReadLine());
        //    RepeatingString(@string, times);
        //}

        //static void RepeatingString(string @string, int times)
        //{
        //    for (int i = 0; i < times; i++)
        //    {
        //        Console.Write(@string);
        //    }
        //}
    }
}
