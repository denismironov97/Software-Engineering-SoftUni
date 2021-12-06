using System;
using System.Text;

namespace Ex._01.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] usernameData = Console.ReadLine().Split(", ");
            StringBuilder validUsernames = new StringBuilder();

            foreach (string username in usernameData)
            {
                int usernameLengh = username.Length;
                bool validLengh = usernameLengh >= 3 && usernameLengh <= 16;
                bool isInvalidCharFound = false;

                if (validLengh)
                {
                    foreach (char letter in username)
                    {
                        int asciiCodeNumber = letter;

                        if (asciiCodeNumber >= 32 && asciiCodeNumber <= 44 || asciiCodeNumber == 46 || asciiCodeNumber == 47 || asciiCodeNumber >= 58 && asciiCodeNumber <= 64
                            || asciiCodeNumber >= 91 && asciiCodeNumber <= 94 || asciiCodeNumber == 96 || asciiCodeNumber >= 123 && asciiCodeNumber <= 126)
                        {
                            isInvalidCharFound = true;
                            break;
                        }
                    }

                    if (isInvalidCharFound == false)
                    {
                        validUsernames.AppendLine(username);
                    }
                }
            }

            Console.Write(validUsernames);
        }
    }
}
