using System;

namespace Lab._01.ReadText
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            string text = "";

            while ((text = Console.ReadLine()) != "Stop")
            {
                Console.WriteLine(text);
            }
            
            //2
            //string text = Console.ReadLine();

            //while (text != "Stop")
            //{
            //    Console.WriteLine(text);
            //    text = Console.ReadLine();
            //}
            //
            //3
            //string text = "";

            //while (text != "Stop")
            //{
            //    text = Console.ReadLine();
            //
            //    if (text == "Stop")
            //    {
            //        break;
            //    }
            //
            //    Console.WriteLine(text);
            //}

            //4
            //string text = "";

            //while (true)
            //{
            //    text = Console.ReadLine();
            //
            //    if (text == "Stop")
            //    {
            //        break;
            //    }
            //
            //    Console.WriteLine(text);
            //}
        }
    }
}
