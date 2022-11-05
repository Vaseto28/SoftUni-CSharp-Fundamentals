using System;

namespace T11.MathOperators
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNum = int.Parse(Console.ReadLine());
            var @operator = char.Parse(Console.ReadLine());
            var secondNum = int.Parse(Console.ReadLine());
            switch (@operator)
            {
                case '+':
                    var sum = AddingNumbers(firstNum, secondNum);
                    Console.WriteLine(sum);
                    break;
                case '-':
                    var subtraction = SubtractingNumbers(firstNum, secondNum);
                    Console.WriteLine(subtraction);
                    break;
                case '*':
                    var multiplication = MultiplyingNumbers(firstNum, secondNum);
                    Console.WriteLine(multiplication);
                    break;
                case '/':
                    var devision = DevidingNumbers(firstNum, secondNum);
                    Console.WriteLine(devision);
                    break;
            }
        }

        static int AddingNumbers(int firstNum, int secondNum)
        {
            var sum = firstNum + secondNum;
            return sum;
        }

        static int SubtractingNumbers(int firstNum, int secondNum)
        {
            var subtract = firstNum - secondNum;
            return subtract;
        }

        static int MultiplyingNumbers(int firstNum, int secondNum)
        {
            var multiplication = firstNum * secondNum;
            return multiplication;
        }

        static int DevidingNumbers(int firstNum, int secondNum)
        {
            var devision = firstNum / secondNum;
            return devision;
        }
    }
}
