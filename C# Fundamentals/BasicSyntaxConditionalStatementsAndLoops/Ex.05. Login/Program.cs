using System;

namespace Ex._05._Login
{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int usernameLenght = username.Length; // num representation of lenght of text;
            string password = string.Empty;
            //char name = username[usernameLenght - 1]; // the last char/letter of the text;
            for (int i = usernameLenght - 1; i >= 0; i--)
            {
                // Console.WriteLine(username[i]); Obhodvane(Crawling) of the word(username) in reverse;
                password = password + username[i];
            }
            for (int tries = 1; tries <= 4; tries++)
            {
                string matchPassword = Console.ReadLine();
                if (matchPassword == password)
                {
                    Console.WriteLine($"User {username} logged in.");
                    break;
                }
                else if (tries == 4 && matchPassword != password)
                {
                    Console.WriteLine($"User {username} blocked!");
                    break;
                }
                else if (matchPassword != password)
                {
                    Console.WriteLine("Incorrect password. Try again.");
                }
            }
        }
    }
}
