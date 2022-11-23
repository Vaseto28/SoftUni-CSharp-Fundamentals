using System;
using System.Text;

namespace T01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inputMessage = Console.ReadLine();

            string command;
            while ((command = Console.ReadLine()) != "Reveal")
            {
                string[] commandInfo = command.Split(":|:");

                string action = commandInfo[0];

                switch (action)
                {
                    case "InsertSpace":
                        int index = int.Parse(commandInfo[1]);
                        inputMessage = inputMessage.Insert(index, " ");
                        Console.WriteLine(inputMessage);
                        break;
                    case "Reverse":
                        string subString = commandInfo[1];

                        if (inputMessage.Contains(subString))
                        {
                            int startIndex = inputMessage.IndexOf(subString);
                            inputMessage = inputMessage.Remove(startIndex, subString.Length);

                            StringBuilder reversedSubString = new StringBuilder();
                            for (int i = subString.Length - 1; i >= 0; i--)
                            {
                                reversedSubString.Append(subString[i]);
                            }

                            inputMessage = inputMessage + reversedSubString.ToString();
                            Console.WriteLine(inputMessage);
                        }
                        else
                        {
                            Console.WriteLine("error");
                        }
                        break;
                    case "ChangeAll":
                        string substring = commandInfo[1];
                        string replacement = commandInfo[2];

                        inputMessage = inputMessage.Replace(substring, replacement);
                        Console.WriteLine(inputMessage);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {inputMessage}");
        }
    }
}
