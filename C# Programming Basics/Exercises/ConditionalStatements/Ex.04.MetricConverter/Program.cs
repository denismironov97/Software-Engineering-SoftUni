using System;

namespace Ex._04.MetricConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string numInMetricSystem = Console.ReadLine(); // from m
            string numToConvert = Console.ReadLine(); // to cm 
            
            if (numToConvert == "mm") // to mm
            {
                if (numInMetricSystem == "mm") // from mm to mm
                {
                    Console.WriteLine($"{number:f3}");
                }
                else if (numInMetricSystem == "cm")
                {
                    double mm = number * 10;
                    Console.WriteLine($"{mm:f3}");
                }
                else if (numInMetricSystem == "m")
                {
                    double mm = number * 1000;
                    Console.WriteLine($"{mm:f3}");
                }
            }
            else if (numToConvert == "cm") // to cm
            {
                if (numInMetricSystem == "mm") // from mm to cm
                {
                    double cm = number / 10;
                    Console.WriteLine($"{cm:f3}");
                }
                else if (numInMetricSystem == "cm")
                {
                    Console.WriteLine($"{number:f3}");
                }
                else if (numInMetricSystem == "m") // from m to cm 
                {
                    double cm = number * 100;
                    Console.WriteLine($"{cm:f3}");
                }
            }
            else if (numToConvert == "m") // to m 
            {
                if (numInMetricSystem == "mm") // from mm to m
                {
                    double m = number / 1000;
                    Console.WriteLine($"{m:f3}");
                }
                else if (numInMetricSystem == "cm")
                {
                    double m = number / 100;
                    Console.WriteLine($"{m:f3}");
                }
                else if (numInMetricSystem == "m")
                {
                    Console.WriteLine($"{number:f3}");
                }
            }
        }
    }
}
