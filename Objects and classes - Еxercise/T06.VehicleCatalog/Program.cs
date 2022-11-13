using System;
using System.Linq;
using System.Collections.Generic;

namespace T06.VehicleCatalog
{
    class Vehicle
    {
        public Vehicle(string type, string model, string color, int horsepower)
        {
            this.Type = type;
            this.Model = model;
            this.Color = color;
            this.Horsepower = horsepower;
        }

        public string Type { get; set; }

        public string Model { get; set; }

        public string Color { get; set; }

        public int Horsepower { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            int horsepowersOfCars = 0;
            int horsepowersOfTrucks = 0;
            int carCounter = 0;
            int truckCounter = 0;
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] information = command.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string typeOfVehicle = information[0];
                string model = information[1];
                string color = information[2];
                int horsepower = int.Parse(information[3]);

                Vehicle newVehicle = new Vehicle(typeOfVehicle, model, color, horsepower);
                vehicles.Add(newVehicle);

                if (typeOfVehicle == "car")
                {
                    horsepowersOfCars += horsepower;
                    carCounter++;
                }
                else
                {
                    horsepowersOfTrucks += horsepower;
                    truckCounter++;
                }
            }

            string modelForSpecifications;
            while ((modelForSpecifications = Console.ReadLine()) != "Close the Catalogue")
            {
                Vehicle vehicleToSearch = vehicles.FirstOrDefault(v => v.Model == modelForSpecifications);
                if (vehicleToSearch.Type == "car")
                {
                    Console.WriteLine($"Type: Car");
                }
                else
                {
                    Console.WriteLine($"Type: Truck");
                }
                Console.WriteLine($"Model: {vehicleToSearch.Model}");
                Console.WriteLine($"Color: {vehicleToSearch.Color}");
                Console.WriteLine($"Horsepower: {vehicleToSearch.Horsepower}");
            }

            if (carCounter == 0)
            {
                carCounter++;
            }

            if (truckCounter == 0)
            {
                truckCounter++;
            }
            
            Console.WriteLine($"Cars have average horsepower of: {(double)horsepowersOfCars / carCounter:f2}.");
            Console.WriteLine($"Trucks have average horsepower of: {(double)horsepowersOfTrucks / truckCounter:f2}.");
        }
    }
}
