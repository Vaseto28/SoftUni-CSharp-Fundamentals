using System;
using System.Collections.Generic;

namespace T03.Articles2._0
{
    class Article
    {
        public Article(string title, string content, string author)
        {
            this.Title = title;
            this.Content = content;
            this.Author = author;
        }

        public string Title { get; set; }

        public string Content { get; set; }

        public string Author { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int numberOfArticles = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();

            for (int i = 1; i <= numberOfArticles; i++)
            {
                string command = Console.ReadLine();
                string[] arguments = command.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = arguments[0];
                string content = arguments[1];
                string author = arguments[2];
                Article newArticle = new Article(title, content, author);
                articles.Add(newArticle);
            }

            string lastCommand = Console.ReadLine();
            foreach (var article in articles)
            {
                Console.WriteLine($"{article.Title} - {article.Content}: {article.Author}");
            }
        }
    }
}
