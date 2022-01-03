using System;
using System.Text;

namespace Ex._04.CaesarCipherModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder encryptedmessage = new StringBuilder();

            //string encryptedmessage = string.Empty;

            //for (int i = 0; i < message.Length; i++)
            //{
            //    char originalSymbol = message[i];
            //    char encrypedSymbol = (char)(message[i] + 3);
            //    encryptedmessage += encrypedSymbol;
            //}
            //Console.WriteLine(encryptedmessage);


            //foreach (char symbol in message)
            //{
            //    char encryptedSymbol = (char)(symbol + 3);
            //    message = message.Replace(symbol, encryptedSymbol);
            //}
            //Console.WriteLine(message);

            foreach (char symbol in message)
            {
                char encryptedSymbol = (char)(symbol + 3);
                encryptedmessage.Append(encryptedSymbol);
            }

            Console.WriteLine(encryptedmessage.ToString());
        }
    }
}
