using System;

namespace Ex._04.PasswordValidatorModV1
{
    class Program
    {
        static void Main(string[] args)
        {
            string passwordInput = Console.ReadLine();
            ValidatePassword(passwordInput);
        }

        static void ValidatePassword(string text)
        {
            bool invalidPassword = false;
            int passwordLenght = text.Length;
            if (passwordLenght < 6 || passwordLenght > 10)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
                invalidPassword = true;
            }
            if (!CheckIfContainsOnlyDigitsAndLetters(passwordLenght, text))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                invalidPassword = true;
            }
            if (CountNumDigits(text) < 2)
            {
                Console.WriteLine("Password must have at least 2 digits");
                invalidPassword = true;
            }

            if (!invalidPassword)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool CheckIfContainsOnlyDigitsAndLetters(int lenghtOfPassword, string text)
        {
            for (int i = 0; i < lenghtOfPassword; i++)
            {
                char currentChar = text[i];
                if (!((currentChar >= 48 && currentChar <= 57)
                    || (currentChar >= 65 && currentChar <= 90)
                    || (currentChar >= 97 && currentChar <= 122)))
                {
                    return false;
                }
            }
            return true;
        }

        static int CountNumDigits(string text)
        {
            int digitCount = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char currentDigit = text[i];
                if (currentDigit >= 48 && currentDigit <= 57)
                {
                    digitCount++;
                }
            }
            return digitCount;
        }
    }
}
