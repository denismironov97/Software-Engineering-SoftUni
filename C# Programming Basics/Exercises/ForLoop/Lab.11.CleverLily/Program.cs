using System;

namespace Lab._11.CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            int toyPrice = int.Parse(Console.ReadLine());

            int moneyFromBirthdays = 0;
            int moneyGift = 10;

            int toysCount = 0;

            for (int birthDay = 1; birthDay <= age; birthDay++)
            {
                if (birthDay % 2 == 0)
                {
                    moneyFromBirthdays = moneyFromBirthdays + moneyGift;
                    moneyGift = moneyGift + 10;
                    moneyFromBirthdays -= 1;
                }
                else
                {
                    toysCount++;
                }
            }

            int moneyFromToys = toysCount * toyPrice;
            moneyFromBirthdays += moneyFromToys;

            if (moneyFromBirthdays >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(moneyFromBirthdays - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(Math.Abs(moneyFromBirthdays - washingMachinePrice)):f2}");
            }
        }
    }
}
