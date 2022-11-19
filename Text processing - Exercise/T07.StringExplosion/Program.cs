using System;
using System.Text;

namespace T07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bombField = Console.ReadLine();
            StringBuilder fieldWithoutBombs = new StringBuilder();
            int bombPower = 0;

            for (int i = 0; i < bombField.Length; i++)
            {
                char currCharacter = bombField[i];
                if (!(currCharacter == '>'))
                {
                    if (bombPower > 0)
                    {
                        bombPower--;
                        continue;
                    }
                    else
                    {
                        fieldWithoutBombs.Append(currCharacter);
                    }
                }
                else
                {
                    bombPower += bombField[i + 1] - 48;
                    fieldWithoutBombs.Append(currCharacter);
                    continue;
                }
            }

            Console.WriteLine(fieldWithoutBombs.ToString());
        }
    }
}
