using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace Ex._06.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string commandData = string.Empty;
            VehicleCatalog catalog = new VehicleCatalog();
            while ((commandData = Console.ReadLine()) != "End")
            {
                string[] vehicleDataParts = commandData.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string vehicleType = vehicleDataParts[0];
                string model = vehicleDataParts[1];
                string color = vehicleDataParts[2];
                int horsePower = int.Parse(vehicleDataParts[3]);

                AddByVehicleType(vehicleType, model, color, horsePower, catalog);
            }

            string searchInstruction = string.Empty;
            while ((searchInstruction = Console.ReadLine()) != "Close the Catalogue")
            {
                foreach (Car currCar in catalog.Cars)
                {
                    if (currCar.Model == searchInstruction)
                    {
                        Console.WriteLine(currCar);
                        break;
                    }
                }

                foreach (Truck truck in catalog.Trucks)
                {
                    if (truck.Model == searchInstruction)
                    {
                        Console.WriteLine(truck);
                        break;
                    }
                }
            }

            double averageCarHP = catalog.AverageCarHorsepower;
            double averageTruckHP = catalog.AverageTruckHorsepower;
            Console.WriteLine($"Cars have average horsepower of: {averageCarHP:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {averageTruckHP:f2}.");
        }

        private static void AddByVehicleType(string vehicleType, string model, string color, int horsePower, VehicleCatalog vehicleCatalog)
        {
            object vehicle;
            switch (vehicleType)
            {
                case "car":
                    vehicle = new Car(model, color, horsePower);
                    vehicleCatalog.Cars.Add((Car)vehicle);
                    break;
                case "truck":
                    vehicle = new Truck(model, color, horsePower);
                    vehicleCatalog.Trucks.Add((Truck)vehicle);
                    break;
            }
        }
    }

    class Car
    {
        public Car(string model, string color, int horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Type: {this.GetType().Name}");
            builder.AppendLine($"Model: {this.Model}");
            builder.AppendLine($"Color: {this.Color}");
            builder.AppendLine($"Horsepower: {this.Horsepower}");

            return builder.ToString().TrimEnd();
        }
    }

    class Truck
    {
        public Truck(string model, string color, int horsepower)
        {
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Model { get; set; }
        public string Color { get; set; }
        public int Horsepower { get; set; }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.AppendLine($"Type: {this.GetType().Name}");
            builder.AppendLine($"Model: {this.Model}");
            builder.AppendLine($"Color: {this.Color}");
            builder.AppendLine($"Horsepower: {this.Horsepower}");

            return builder.ToString().TrimEnd();
        }
    }

    class VehicleCatalog
    {
        public List<Car> Cars { get; set; } = new List<Car>();
        public List<Truck> Trucks { get; set; } = new List<Truck>();

        public double AverageCarHorsepower
        {
            get
            {
                if (this.Cars.Any())
                {
                    return GetAverageCarHorsepower();
                }

                return 0;
            }
        }
        public double AverageTruckHorsepower
        {
            get
            {
                if (this.Trucks.Any())
                {
                    return GetAverageTruckHorsepower();
                }

                return 0;
            }
        }

        private double GetAverageCarHorsepower()
        {
            double tempSum = 0;
            foreach (Car car in this.Cars)
            {
                tempSum += car.Horsepower;
            }

            return tempSum / this.Cars.Count;
        }

        private double GetAverageTruckHorsepower()
        {
            double tempSum = 0;
            foreach (Truck truck in this.Trucks)
            {
                tempSum += truck.Horsepower;
            }

            return tempSum / this.Trucks.Count;
        }

    }
}
