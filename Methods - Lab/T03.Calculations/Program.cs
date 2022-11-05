using System;

namespace T03.Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            var action = Console.ReadLine();
            var firstNum = int.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            CalculatingNumbers(action, firstNum, secondNum);
        }

        static void CalculatingNumbers(string action, int firstNum, int secondNum)
        {
            switch (action)
            {
                case "add":
                    var sum = firstNum + secondNum;
                    Console.WriteLine(sum);
                    break;
                case "subtract":
                    var subtraction = firstNum - secondNum;
                    Console.WriteLine(subtraction);
                    break;
                case "multiply":
                    var multiplication = firstNum * secondNum;
                    Console.WriteLine(multiplication);
                    break;
                case "devide":
                    var devision = firstNum / secondNum;
                    Console.WriteLine(devision);
                    break;
            }
        }
    }
}
