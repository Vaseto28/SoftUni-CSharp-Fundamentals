using System;
using System.Text;

namespace T03.CharactersInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstChar = char.Parse(Console.ReadLine());
            var secondChar = char.Parse(Console.ReadLine());
            CharactersInInterval(firstChar, secondChar);
        }

        static void CharactersInInterval(char firstChar, char secondChar)
        {
            StringBuilder result = new StringBuilder();
            var theRightValueOfTheFirstChar = firstChar;
            if (secondChar<firstChar)
            {
                firstChar = secondChar;
                secondChar = theRightValueOfTheFirstChar;
            }
            for (char i = ++firstChar; i < secondChar; i++)
            {
                result.Append($"{i} ");
            }
            Console.Write(result);
        }
    }
}
