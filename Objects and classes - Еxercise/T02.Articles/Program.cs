using System;

namespace T02.Articles
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
            string input = Console.ReadLine();
            string[] inputData = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = inputData[0];
            string content = inputData[1];
            string author = inputData[2];
            Article newArticle = new Article(title, content, author);

            int commands = int.Parse(Console.ReadLine());
            for (int i = 0; i < commands; i++)
            {
                string command = Console.ReadLine();
                string[] arguments = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string action = arguments[0];

                if (action == "Edit:")
                {
                    string newContent = String.Empty;
                    for (int j = 1; j < arguments.Length; j++)
                    {
                        string currContent = arguments[j];
                        newContent += currContent;
                        if (j < arguments.Length - 1)
                        {
                            newContent += " ";
                        }
                    }
                    Edit(newArticle, newContent);
                }
                else if (action == "ChangeAuthor:")
                {
                    string newAuthor = String.Empty;
                    for (int k = 1; k < arguments.Length; k++)
                    {
                        string currAuthor = arguments[k];
                        newAuthor += currAuthor;
                        if (k < arguments.Length - 1)
                        {
                            newAuthor += " ";
                        }
                    }
                    ChangeAuthor(newArticle, newAuthor);
                }
                else if (action == "Rename:")
                {
                    string newTitle = String.Empty;
                    for (int l = 1; l < arguments.Length; l++)
                    {
                        string currTitle = arguments[l];
                        newTitle += currTitle;
                        if (l < arguments.Length - 1)
                        {
                            newTitle += " ";
                        }
                    }
                    Rename(newArticle, newTitle);
                }
            }

            Console.WriteLine($"{newArticle.Title} - {newArticle.Content}: {newArticle.Author}");
        }

        static void Edit(Article newArticle, string newContent)
        {
            newArticle.Content = newContent;
        }

        static void ChangeAuthor(Article newArticle, string newAuthor)
        {
            newArticle.Author = newAuthor;
        }

        static void Rename(Article newArticle, string newTitle)
        {
            newArticle.Title = newTitle;
        }
    }
}
