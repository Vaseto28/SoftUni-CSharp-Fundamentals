using System;
using System.Collections.Generic;
using System.Text;

namespace T01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            List<string> validNames = new List<string>();

            foreach (string name in names)
            {
                if (name.Length >= 3 && name.Length <= 16)
                {
                    int occurancy = 0;
                    foreach (var currCharacter in name)
                    {
                        if (Char.IsLetterOrDigit(currCharacter) || currCharacter == '-' || currCharacter == '_')
                        {
                            occurancy++;
                            continue;
                        }
                        else
                        {
                            occurancy = 0;
                            break;
                        }
                    }

                    if (occurancy > 0)
                    {
                        validNames.Add(name);
                    }
                }
                else
                {
                    continue;
                }
            }

            Console.WriteLine(String.Join(Environment.NewLine, validNames));
        }
    }
}
