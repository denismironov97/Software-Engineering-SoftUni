using System;

namespace L._05.DigitsLettersAndOther
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = Console.ReadLine();
            string dataTypeString = string.Empty;
            string dataTypeDigit = string.Empty;
            string dataTypeCharacter = string.Empty;
            //string junkErrors = "";

            for (int i = 0; i < inputData.Length; i++)
            {
                int characterNumber = inputData[i];

                if (characterNumber >= 97 && characterNumber <= 122 || characterNumber >= 65 && characterNumber <= 90) // Letter
                {
                    dataTypeString += (char)characterNumber;
                }
                else if (characterNumber == 96 || characterNumber >= 123 && characterNumber <= 127 || characterNumber == 64 || characterNumber >= 91 && characterNumber <= 95
                    || characterNumber >= 32 && characterNumber <= 47 || characterNumber >= 58 && characterNumber <= 63) // Character
                {
                    dataTypeCharacter += (char)characterNumber;
                }
                else if (characterNumber >= 48 && characterNumber <= 57) // Digit
                {
                    dataTypeDigit += (char)characterNumber;
                }
                //else
                //{
                //    //junkErrors += (char)characterNumber;
                //}
            }

            Console.WriteLine(dataTypeDigit);
            Console.WriteLine(dataTypeString);
            Console.WriteLine(dataTypeCharacter);
            //Console.WriteLine($"{junkErrors}");
        }
    }
}
