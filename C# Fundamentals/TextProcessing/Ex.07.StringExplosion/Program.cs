using System;
using System.Text;

namespace Ex._07.StringExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            StringBuilder resultText = new StringBuilder();
            int bomb = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>')
                {
                    bomb += text[i + 1] - 48;
                    resultText.Append(text[i]);
                }
                else if (bomb > 0)
                {
                    bomb -= 1;
                }
                else
                {
                    resultText.Append(text[i]);
                }
            }

            Console.WriteLine(resultText);
        }
    }
}
