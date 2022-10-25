using System;

namespace _05.Login
{
    class Program
    {
        static void Main(string[] args)
        {
            var username = Console.ReadLine();
            var password = String.Empty;
            for (int indexOfString = username.Length - 1; indexOfString >= 0; indexOfString--)
            {
                password += username[indexOfString];
            }
            for (int tries = 1; tries <= 4; tries++)
            {
                var enteredPassowrd = Console.ReadLine();
                if (tries <= 4 && password == enteredPassowrd)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                if (tries < 4 && password != enteredPassowrd)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    continue;
                }
                if (tries >= 4 && password != enteredPassowrd)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
            }
        }
    }
}
