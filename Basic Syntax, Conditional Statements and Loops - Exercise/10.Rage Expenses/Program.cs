using System;

namespace _10.Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            var lostGames = int.Parse(Console.ReadLine());
            var headsetPrice = double.Parse(Console.ReadLine());
            var mousePrice = double.Parse(Console.ReadLine());
            var keyboardPrice = double.Parse(Console.ReadLine());
            var displayPrice = double.Parse(Console.ReadLine());
            var totalSum = (lostGames/2)*headsetPrice + (lostGames / 3) * mousePrice + (lostGames / 6) * keyboardPrice + (lostGames / 12) * displayPrice;
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
