using System;

namespace Lab._09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Широчина на свободното пространство - цяло число в интервала[1...1000]
            //2.Дължина на свободното пространство - цяло число в интервала[1...1000]
            //3.Височина на свободното пространство - цяло число в интервала[1...1000]
            //4.На следващите редове(до получаване на команда "Done") -брой кашони, които се пренасят в квартирата - цели числа в интервала[1...10000];
            //Програмата трябва да приключи прочитането на данни при команда "Done" или ако свободното място свърши.
            
            double widthOfFreeSpace = double.Parse(Console.ReadLine());
            double lenghtOfFreeSpace = double.Parse(Console.ReadLine());
            double heightOfFreeSpace = double.Parse(Console.ReadLine());
            string numOfBoxesOrDone = Console.ReadLine(); // reads 1 time;
            int sumOfBoxes = 0;
            double totalVolumeOfBoxes = 0;
            double volumeOfOneBox = 1; // 1m3
            double volumeOfFreeSpaceApartment = widthOfFreeSpace * lenghtOfFreeSpace * heightOfFreeSpace; // m3
            
            while (numOfBoxesOrDone != "Done")
            {
                int currentNumOfBoxes = int.Parse(numOfBoxesOrDone);
                sumOfBoxes += currentNumOfBoxes;
                totalVolumeOfBoxes = volumeOfOneBox * sumOfBoxes;
                if (totalVolumeOfBoxes >= volumeOfFreeSpaceApartment)
                {
                    Console.WriteLine($"No more free space! You need {totalVolumeOfBoxes - volumeOfFreeSpaceApartment} Cubic meters more.");
                    break;
                }
                numOfBoxesOrDone = Console.ReadLine();
            }

            if (totalVolumeOfBoxes < volumeOfFreeSpaceApartment)
            {
                Console.WriteLine($"{volumeOfFreeSpaceApartment - totalVolumeOfBoxes} Cubic meters left.");
            }
        }
    }
}
