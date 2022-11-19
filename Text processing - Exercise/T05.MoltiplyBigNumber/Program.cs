using System;
using System.Numerics;

namespace T05.MoltiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BigInteger firstNum = BigInteger.Parse(Console.ReadLine());
            int nextNum = int.Parse(Console.ReadLine());

            BigInteger sum = new BigInteger();

            sum = firstNum * nextNum;

            Console.WriteLine(sum);
        }
    }
}
