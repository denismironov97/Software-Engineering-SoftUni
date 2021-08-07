using System;

namespace Ex._01.Ages
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputAge = Convert.ToInt32(Console.ReadLine());
            bool baby = inputAge >= 0 && inputAge <= 2;
            bool child = inputAge >= 3 && inputAge <= 13;
            bool teen = inputAge >= 14 && inputAge <= 19;
            bool adult = inputAge >= 20 && inputAge <= 65;
            bool elder = inputAge > 65; // 66 and above
            if (baby)
            {
                Console.WriteLine("baby");
            }
            else if (child)
            {
                Console.WriteLine("child");
            }
            else if (teen)
            {
                Console.WriteLine("teenager");
            }
            else if (adult)
            {
                Console.WriteLine("adult");
            }
            else if (elder)
            {
                Console.WriteLine("elder");
            }
        }
    }
}
