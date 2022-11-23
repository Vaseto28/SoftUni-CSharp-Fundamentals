using System;
using System.Collections.Generic;

namespace T05.NeedForSpeedIII
{
    class Car
    {
        public Car(string carName, int mileage, int fuel)
        {
            this.CarName = carName;
            this.Mileage = mileage;
            this.Fuel = fuel;
        }

        public string CarName { get; set; }

        public int Mileage { get; set; }

        public int Fuel { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());

            Dictionary<string, Car> cars = new Dictionary<string, Car>();

            for (int i = 0; i < numberOfCars; i++)
            {
                string currCar = Console.ReadLine();
                string[] currCarInfo = currCar.Split('|', StringSplitOptions.RemoveEmptyEntries);

                string carName = currCarInfo[0];
                int mileage = int.Parse(currCarInfo[1]);
                int fuel = int.Parse(currCarInfo[2]);

                Car newCar = new Car(carName, mileage, fuel);
                cars.Add(carName, newCar);
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] actionInfo = command.Split(" : ", StringSplitOptions.RemoveEmptyEntries);
                string action = actionInfo[0];
                if (action == "Drive")
                {
                    string carToDrive = actionInfo[1];
                    int distance = int.Parse(actionInfo[2]);
                    int fuelForDriving = int.Parse(actionInfo[3]);

                    if (cars[carToDrive].Fuel < fuelForDriving)
                    {
                        Console.WriteLine("Not enough fuel to make that ride");
                        continue;
                    }
                    else
                    {
                        cars[carToDrive].Mileage += distance;
                        cars[carToDrive].Fuel -= fuelForDriving;

                        Console.WriteLine($"{carToDrive} driven for {distance} kilometers. {fuelForDriving} liters of fuel consumed.");
                        if (cars[carToDrive].Mileage >= 100000)
                        {
                            cars.Remove(carToDrive);
                            Console.WriteLine($"Time to sell the {carToDrive}!");
                        }
                    }
                }
                else if (action == "Refuel")
                {
                    string carToRefuel = actionInfo[1];
                    int fuelForRefueling = int.Parse(actionInfo[2]);

                    cars[carToRefuel].Fuel += fuelForRefueling;
                    if (cars[carToRefuel].Fuel > 75)
                    {
                        Console.WriteLine($"{carToRefuel} refueled with {75 - cars[carToRefuel].Fuel + fuelForRefueling} liters");
                        cars[carToRefuel].Fuel = 75;
                        continue;
                    }

                    Console.WriteLine($"{carToRefuel} refueled with {fuelForRefueling} liters");
                }
                else if (action == "Revert")
                {
                    string carToRevert = actionInfo[1];
                    int kilometers = int.Parse(actionInfo[2]);

                    cars[carToRevert].Mileage -= kilometers;
                    if (cars[carToRevert].Mileage < 10000)
                    {
                        cars[carToRevert].Mileage = 10000;
                    }

                    Console.WriteLine($"{carToRevert} mileage decreased by {kilometers} kilometers");
                }
            }

            foreach (var car in cars)
            {
                Car currCar = car.Value;
                Console.WriteLine($"{car.Key} -> Mileage: {currCar.Mileage} kms, Fuel in the tank: {currCar.Fuel} lt.");
            }
        }
    }
}
