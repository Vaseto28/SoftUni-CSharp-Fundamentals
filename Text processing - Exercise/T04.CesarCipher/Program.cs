using System;
using System.Text;

namespace T04.CesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            StringBuilder encryptedText = new StringBuilder();

            foreach (var character in text)
            {
                int encryptedCharacterInInt = character + 3;
                char encryptedCharacter = (char)encryptedCharacterInInt;
                encryptedText.Append(encryptedCharacter);
            }

            Console.WriteLine(encryptedText.ToString());
        }
    }
}
