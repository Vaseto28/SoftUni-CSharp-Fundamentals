using System;

namespace T09.GraterOfTwoValues
{
    class Program
    {
        static void Main(string[] args)
        {
            var type = Console.ReadLine();
            switch (type)
            {
                case "int":
                    var firstIntValue = int.Parse(Console.ReadLine());
                    var secondIntValue = int.Parse(Console.ReadLine());
                    var graterIntValue = GraterIntValue(firstIntValue, secondIntValue);
                    Console.WriteLine(graterIntValue);
                    break;
                case "char":
                    var firstCharValue = char.Parse(Console.ReadLine());
                    var secondCharValue = char.Parse(Console.ReadLine());
                    var graterCharValue = GraterCharValue(firstCharValue, secondCharValue);
                    Console.WriteLine(graterCharValue);
                    break;
                case "string":
                    var firstStringValue = Console.ReadLine();
                    var secondStringValue = Console.ReadLine();
                    var graterStringValue = GraterStringValue(firstStringValue, secondStringValue);
                    Console.WriteLine(graterStringValue);
                    break;
            }
        }

        static int GraterIntValue(int firstValue, int secondValue)
        {
            return (firstValue > secondValue) ? firstValue : secondValue;
        }
        static char GraterCharValue(char firstValue, char secondValue)
        {
            return (firstValue > secondValue) ? firstValue : secondValue;
        }
        static string GraterStringValue(string firstValue, string secondValue)
        {
            return firstValue.CompareTo(secondValue) >= 0 ? firstValue : secondValue;
        }
    }
}
