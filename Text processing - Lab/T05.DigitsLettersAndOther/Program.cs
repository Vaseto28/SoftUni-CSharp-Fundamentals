using System;
using System.Linq;

namespace T05.DigitsLettersAndOther
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            char[] chars = text.ToCharArray();

            char[] digits = text.Where(character => char.IsDigit(character)).ToArray();
            char[] letters = text.Where(character => char.IsLetter(character)).ToArray();
            char[] other = text.Where(character => !char.IsLetterOrDigit(character)).ToArray();

            Console.WriteLine(String.Join("", digits));
            Console.WriteLine(String.Join("", letters));
            Console.WriteLine(String.Join("", other));
        }
    }
}
