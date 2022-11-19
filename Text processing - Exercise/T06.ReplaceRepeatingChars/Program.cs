using System;
using System.Text;

namespace T06.ReplaceRepeatingChars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string result = String.Empty;

            for (int i = 0; i < text.Length; i++)
            {
                char currCharacter = text[i];
                if (i == text.Length - 1)
                {
                    if (result.Contains(currCharacter))
                    {
                        break;
                    }
                    else
                    {
                        result += currCharacter;
                        break;
                    }
                }
                else
                {
                    char nextCharacter = text[i + 1];
                    if (!(currCharacter == nextCharacter))
                    {
                        if (result.Contains(currCharacter))
                        {
                            result += nextCharacter;
                            continue;
                        }

                        if (result.Contains(nextCharacter))
                        {
                            continue;
                        }

                        result += currCharacter;
                        result += nextCharacter;
                    }
                    else
                    {
                        continue;
                    }
                }
            }

            Console.WriteLine(result);
        }
    }
}
