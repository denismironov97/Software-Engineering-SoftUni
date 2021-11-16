using System;
using System.Linq;
using System.Collections.Generic;

namespace Ex._05.SoftUniParking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfCommands = int.Parse(Console.ReadLine());
            Dictionary<string, string> parkingInformnation = new Dictionary<string, string>();

            for (int i = 0; i < numOfCommands; i++)
            {
                string[] inputData = Console.ReadLine().Split(' ');
                string command = inputData[0];
                string nameOfPerson = inputData[1];

                if (command == "register")
                {
                    string licensePlateNumber = inputData[2];

                    if (!parkingInformnation.ContainsKey(nameOfPerson))
                    {
                        parkingInformnation.Add(nameOfPerson, licensePlateNumber);
                        Console.WriteLine($"{nameOfPerson} registered {licensePlateNumber} successfully");
                    }
                    else
                    {
                        foreach (var kvp in parkingInformnation)
                        {
                            string username = kvp.Key;
                            string plateNumber = kvp.Value;

                            if (username == nameOfPerson && plateNumber == licensePlateNumber
                                || username == nameOfPerson && plateNumber != licensePlateNumber) //important did it by myself and I'm proud
                            {
                                Console.WriteLine($"ERROR: already registered with plate number {plateNumber}");
                                break;
                            }
                        }
                    }
                }
                else //unregister
                {
                    if (!parkingInformnation.ContainsKey(nameOfPerson))
                    {
                        Console.WriteLine($"ERROR: user {nameOfPerson} not found");
                    }
                    else
                    {
                        parkingInformnation.Remove(nameOfPerson);
                        Console.WriteLine($"{nameOfPerson} unregistered successfully");
                    }
                }
            }

            foreach (var kvp in parkingInformnation)
            {
                Console.WriteLine($"{kvp.Key} => {kvp.Value}");
            }
        }
    }
}
