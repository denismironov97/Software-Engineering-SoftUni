using System;
using System.Linq;
using System.Collections.Generic;

namespace L._07.VehicleCatalogue
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputData = string.Empty;
            Catalog catalog = new Catalog();
            while ((inputData = Console.ReadLine()) != "end")
            {
                string[] vehicleInformation = inputData.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string vehicleType = vehicleInformation[0];
                string brand = vehicleInformation[1];
                string model = vehicleInformation[2];

                if (vehicleType == "Truck")
                {
                    int weight = int.Parse(vehicleInformation[3]);

                    Truck truck = new Truck()
                    {
                        Brand = brand,
                        Model = model,
                        Weight = weight
                    };

                    catalog.Trucks.Add(truck);
                }
                else
                {
                    int horsePower = int.Parse(vehicleInformation[3]);

                    Car car = new Car()
                    {
                        Brand = brand,
                        Model = model,
                        HorsePower = horsePower
                    };

                    catalog.Cars.Add(car);
                }
            }

            if (catalog.Cars.Count > 0)//catalog.Cars.Count != 0
            {
                Console.WriteLine("Cars:");
            }
            foreach (Car car in catalog.Cars.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{car.Brand}: {car.Model} - {car.HorsePower}hp");
            }

            if (catalog.Trucks.Any())
            {
                Console.WriteLine("Trucks:");
            }
            foreach (Truck truck in catalog.Trucks.OrderBy(x => x.Brand))
            {
                Console.WriteLine($"{truck.Brand}: {truck.Model} - {truck.Weight}kg");
            }
        }
    }

    public class Truck
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Weight { get; set; }
    }

    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int HorsePower { get; set; }
    }

    public class Catalog
    {
        public Catalog()
        {
            this.Trucks = new List<Truck>();
            this.Cars = new List<Car>();
        }
        public List<Truck> Trucks { get; set; }
        public List<Car> Cars { get; set; }
    }
}
