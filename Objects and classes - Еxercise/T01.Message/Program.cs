using System;
using System.Collections.Generic;

namespace T01.Message
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] phrases = {
                "Excellent product.",
                "Such a great product.",
                "I always use that product.",
                "Best product of its category.",
                "Exceptional product.",
                "I can’t live without this product."
            };

            string[] events = { 
                "Now I feel good.", 
                "I have succeeded with this product.", 
                "Makes miracles. I am happy of the results!", 
                "I cannot believe but now I feel awesome.", 
                "Try it yourself, I am very satisfied.", 
                "I feel great!" 
            };

            string[] authors = { 
                "Diana", 
                "Petya", 
                "Stella", 
                "Elena", 
                "Katya", 
                "Iva", 
                "Annie", 
                "Eva" 
            };

            string[] cities = {
                "Burgas",
                "Sofia",
                "Plovdiv",
                "Varna",
                "Ruse"
            };

            string[] result = new string[4];

            Random randomPhrase = new Random();
            Random randomEvent = new Random();
            Random randomAuthor = new Random();
            Random randomCity = new Random();

            int randPhrase = randomPhrase.Next(0, 6);
            int randEvent = randomEvent.Next(0, 6);
            int randAuthor = randomAuthor.Next(0, 8);
            int randCity = randomCity.Next(0, 5);

            result[0] = phrases[randPhrase];
            result[1] = events[randEvent];
            result[2] = authors[randAuthor];
            result[3] = cities[randCity];

            Console.WriteLine($"{result[0]} {result[1]} {result[2]} – {result[3]}.");
        }
    }
}
