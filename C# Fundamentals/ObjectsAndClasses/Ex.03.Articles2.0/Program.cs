using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._03.Articles2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLinesInput = int.Parse(Console.ReadLine());
            List<Article> articles = new List<Article>();
            for (int i = 0; i < nLinesInput; i++)
            {
                string[] articleData = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string title = articleData[0];
                string content = articleData[1];
                string author = articleData[2];
                Article currArticle = new Article(title, content, author);
                articles.Add(currArticle);
            }

            string appliedFilter = Console.ReadLine();
            List<Article> filteredArticles;
            switch (appliedFilter)
            {
                case "title":
                    filteredArticles = articles.OrderBy(x => x.Title).ToList();
                    break;
                case "content":
                    filteredArticles = articles.OrderBy(x => x.Content).ToList();
                    break;
                case "author":
                    filteredArticles = articles.OrderBy(x => x.Author).ToList();
                    break;
                default:
                    filteredArticles = null;
                    break;
            }

            for (int i = 0; i < filteredArticles.Count; i++)
            {
                Console.WriteLine(filteredArticles[i]);
            }
        }
    }

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

        public override string ToString()
        {
            return $"{ this.Title} - { this.Content}: { this.Author}";
        }
    }
}
