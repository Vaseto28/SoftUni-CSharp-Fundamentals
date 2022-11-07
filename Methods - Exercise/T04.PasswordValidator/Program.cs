using System;

namespace T04.PasswordValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = Console.ReadLine();
        }

        static void CheckingForRequiredPasswordLength(string password)
        {
            if (password.Length < 6)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
        }

        static void CheckingForRequiredPasswordDigits(string password)
        {
            var digitsCounter = 0;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] == '0' || password[i] == '1' || password[i] == '2' || password[i] == '3' || password[i] == '4' || password[i] == '5' || password[i] == '6' || password[i] == '7' || password[i] == '8' || password[i] == '9')
                {
                    digitsCounter++;
                }
                if (digitsCounter < 2)
                {
                    Console.WriteLine("Password must have at least 2 digits");
                }
            }
        }

        static void ChechingForAnySymbols(string password)
        {
            for (int i = 0; i < password.Length; i++)
            {
                var currCharacter = password[i];

            }
        }
    }
}
