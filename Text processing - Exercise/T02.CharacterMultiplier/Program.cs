using System;

namespace T02.CharacterMultiplier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] strings = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string firstStr = strings[0];
            string secondStr = strings[1];
            int sum = 0;

            if (firstStr.Length == secondStr.Length)
            {
                for (int i = 0; i < firstStr.Length; i++)
                {
                    char currLetterOfFirstStr = firstStr[i];
                    char currLetterOfSecondStr = secondStr[i];
                    sum += currLetterOfFirstStr * currLetterOfSecondStr;
                }
            }
            else
            {
                string longerString = string.Empty;
                string shorterString = string.Empty;
                if (firstStr.Length > secondStr.Length)
                {
                    longerString = firstStr;
                    shorterString = secondStr;
                }
                else
                {
                    longerString = secondStr;
                    shorterString = firstStr;
                }
                
                string remainingLetters = longerString.Substring(shorterString.Length);

                for (int i = 0; i < shorterString.Length; i++)
                {
                    char currLetterOfFirstStr = firstStr[i];
                    char currLetterOfSecondStr = secondStr[i];
                    sum += currLetterOfFirstStr * currLetterOfSecondStr;
                }

                for (int i = 0; i < remainingLetters.Length; i++)
                {
                    char currChar = remainingLetters[i];
                    sum += currChar;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
