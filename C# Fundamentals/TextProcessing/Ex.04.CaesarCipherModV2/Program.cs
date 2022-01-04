using System;

namespace Ex._04.CaesarCipherModV2
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            string encryptedmessage = string.Empty;

            for (int i = 0; i < message.Length; i++)
            {
                char encrypedSymbol = (char)(message[i] + 3);
                encryptedmessage += encrypedSymbol;
            }

            Console.WriteLine(encryptedmessage);
        }
    }
}
