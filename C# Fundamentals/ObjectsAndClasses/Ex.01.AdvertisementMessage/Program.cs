using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._01.AdvertisementMessage
{
    class Program
    {
        static void Main(string[] args)
        {
            int nLines = int.Parse(Console.ReadLine());
            for (int i = 0; i < nLines; i++)
            {
                Advertisement currAdvert = new Advertisement();
                Console.WriteLine(currAdvert.ToString());
            }
        }
    }
    public class Advertisement
    {
        private string[] predefinedPhrase = new string[]
        {
            "Excellent product.",
            "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."
        };
        private string[] predefinedEvent = new string[]
        {
            "Now I feel good.",
            "I have succeeded with this product.",
            "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.",
            "Try it yourself, I am very satisfied.",
            "I feel great!"
        };
        private string[] predefinedAuthors = new string[]
        {
            "Diana",
            "Petya",
            "Stella",
            "Elena",
            "Katya",
            "Iva",
            "Annie",
            "Eva"
        };
        private string[] predefinedCities = new string[]
        {
            "Burgas",
            "Sofia",
            "Plovdiv",
            "Varna",
            "Ruse"
        };

        private Random randomiser = new Random();

        public Advertisement()
        {
            this.Phrase = GetRandomPhrase();
            this.Event = GetRandomEvent();
            this.Author = GetRandomAuthor();
            this.City = GetRandomCity();
        }

        //Since we are just using the constructor to initialize the object with the already random messages in it we will not be needing a setter
        public string Phrase { get; }
        public string Event { get; }
        public string Author { get; }
        public string City { get; }

        private int GetRandomIndex(int lengthOfArray)
        {
            int randomIndex = this.randomiser.Next(0, lengthOfArray);//From 0 to Length - 1 number(index)
            return randomIndex;
        }

        private string GetRandomPhrase()
        {
            int randomIndex = GetRandomIndex(this.predefinedPhrase.Length);
            return this.predefinedPhrase[randomIndex];
        }

        private string GetRandomEvent()
        {
            int randomIndex = GetRandomIndex(this.predefinedEvent.Length);
            return this.predefinedEvent[randomIndex];
        }

        private string GetRandomAuthor()
        {
            int randomIndex = GetRandomIndex(this.predefinedAuthors.Length);
            return this.predefinedAuthors[randomIndex];
        }

        private string GetRandomCity()
        {
            int randomIndex = GetRandomIndex(this.predefinedCities.Length);
            return this.predefinedCities[randomIndex];
        }

        public override string ToString()
        {
            return $"{this.Phrase} {this.Event} {this.Author} – {this.City}";
        }
    }
}
