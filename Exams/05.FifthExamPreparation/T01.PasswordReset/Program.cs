using System;
using System.Text;

namespace T06.PasswordReset
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();
            string finalPassword = String.Empty;

            string command;
            while ((command = Console.ReadLine()) != "Done")
            {
                string[] actionInfo = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = actionInfo[0];

                if (action == "TakeOdd")
                {
                    StringBuilder newRawPassword = new StringBuilder();
                    for (int i = 0; i < password.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            newRawPassword.Append(password[i]);
                        }
                    }

                    finalPassword = newRawPassword.ToString();
                    Console.WriteLine(finalPassword);
                }
                else if (action == "Cut")
                {
                    int index = int.Parse(actionInfo[1]);
                    int length = int.Parse(actionInfo[2]);

                    finalPassword = finalPassword.Remove(index, length);
                    Console.WriteLine(finalPassword);
                }
                else if (action == "Substitute")
                {
                    string substring = actionInfo[1];
                    string substitute = actionInfo[2];

                    if (!finalPassword.Contains(substring))
                    {
                        Console.WriteLine("Nothing to replace!");
                        continue;
                    }

                    while (finalPassword.Contains(substring))
                    {
                        finalPassword = finalPassword.Replace(substring, substitute);
                    }

                    Console.WriteLine(finalPassword);
                }
            }

            Console.WriteLine($"Your password is: {finalPassword}");
        }
    }
}
