using System;

namespace Ex._02.Articles
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

        public void Edit(string content)
        {
            this.Content = content;
        }

        public void ChangeAuthor(string author)
        {
            this.Author = author;
        }

        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{ this.Title} - { this.Content}: { this.Author}";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            string[] articleData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
            string title = articleData[0];
            string content = articleData[1];
            string author = articleData[2];
            Article articleObj = new Article(title, content, author);

            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                string[] commandParts = Console.ReadLine().Split(": ", StringSplitOptions.RemoveEmptyEntries);
                string appropriateString = commandParts[1];

                switch (commandParts[0])
                {
                    case "Edit":
                        articleObj.Edit(appropriateString);
                        break;
                    case "ChangeAuthor":
                        articleObj.ChangeAuthor(appropriateString);
                        break;
                    case "Rename":
                        articleObj.Rename(appropriateString);
                        break;
                }
            }

            Console.WriteLine(articleObj);
        }
    }
}
