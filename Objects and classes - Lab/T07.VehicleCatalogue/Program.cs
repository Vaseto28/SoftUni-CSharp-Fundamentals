using System;
using System.Linq;
using System.Collections.Generic;

namespace T07.VehicleCatalogue
{
    class Truck
    {
        public Truck(string brand, string model, int weight)
        {
            this.Brand = brand;
            this.Model = model;
            this.Weight = weight;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int Weight { get; set; }
    }

    class Car
    {
        public Car(string brand, string model, int horsePower)
        {
            this.Brand = brand;
            this.Model = model;
            this.HorsePower = horsePower;
        }

        public string Brand { get; set; }

        public string Model { get; set; }

        public int HorsePower { get; set; }
    }

    class Catalogue
    {
        public Catalogue(List<Car> cars, List<Truck> trucks)
        {
            this.Cars = cars;
            this.Trucks = trucks;
        }

        public List<Car> Cars { get; set; }

        public List<Truck> Trucks { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Truck> trucks = new List<Truck>();
            List<Car> cars = new List<Car>();

            string command;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] arguments = command.Split('/', StringSplitOptions.RemoveEmptyEntries);
                string type = arguments[0];
                if (type == "Car")
                {
                    string brand = arguments[1];
                    string model = arguments[2];
                    int horsePower = int.Parse(arguments[3]);
                    Car car = new Car(brand, model, horsePower);
                    cars.Add(car);
                }
                else if (type == "Truck")
                {
                    string brand = arguments[1];
                    string model = arguments[2];
                    int weight = int.Parse(arguments[3]);
                    Truck truck = new Truck(brand, model, weight);
                    trucks.Add(truck);
                }
            }

            List<Car> orderedCars = cars.OrderBy(x => x.Brand).ToList();
            List<Truck> orderedtrucks = trucks.OrderBy(x => x.Brand).ToList();

            Catalogue catalogue = new Catalogue(orderedCars, orderedtrucks);

            if (orderedCars.Count > 0)
            {
                Console.WriteLine("Cars:");
                for (int i = 0; i < orderedCars.Count; i++)
                {
                    Console.WriteLine($"{orderedCars[i].Brand}: {orderedCars[i].Model} - {orderedCars[i].HorsePower}hp");
                }
            }

            if (orderedtrucks.Count > 0)
            {
                Console.WriteLine("Trucks:");
                for (int i = 0; i < orderedtrucks.Count; i++)
                {
                    Console.WriteLine($"{orderedtrucks[i].Brand}: {orderedtrucks[i].Model} - {orderedtrucks[i].Weight}kg");
                }
            }
        }
    }
}
