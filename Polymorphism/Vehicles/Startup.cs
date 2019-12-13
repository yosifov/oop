namespace OOP.Polymorphism.Vehicles
{
    using System;
    using OOP.Polymorphism.Vehicles.Models;

    public class Startup
    {
        public static void Execute()
        {
            Car car = null;
            Truck truck = null;
            double fuelQuantity;
            double fuelConsumptionPerKm;

            while (true)
            {
                string carInfo = Console.ReadLine();
                if (carInfo.Split()[0] != "Car")
                {
                    Console.WriteLine("Invalid Car input. Try again:");
                    continue;
                }
                else
                {
                    try
                    {
                        fuelQuantity = double.Parse(carInfo.Split()[1]);
                        fuelConsumptionPerKm = double.Parse(carInfo.Split()[2]);

                        car = new Car(fuelQuantity, fuelConsumptionPerKm, true, false);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Try again:");
                        continue;
                    }
                }
            }

            while (true)
            {
                string truckInfo = Console.ReadLine();
                if (truckInfo.Split()[0] != "Truck")
                {
                    Console.WriteLine("Invalid Truck input. Try again:");
                    continue;
                }
                else
                {
                    try
                    {
                        fuelQuantity = double.Parse(truckInfo.Split()[1]);
                        fuelConsumptionPerKm = double.Parse(truckInfo.Split()[2]);

                        truck = new Truck(fuelQuantity, fuelConsumptionPerKm, true, true);
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message + ". Try again:");
                        continue;
                    }
                }
            }
            
            try
            {
                int actions = int.Parse(Console.ReadLine());

                for (int i = 1; i <= actions; i++)
                {
                    string command = Console.ReadLine();
                    if (command.Split().Length != 3)
                    {
                        Console.WriteLine("Invalid action");
                    }
                    else
                    {
                        string commandType = command.Split()[0];
                        string vehicleType = command.Split()[1];
                        double commandValue = double.Parse(command.Split()[2]);

                        switch (commandType)
                        {
                            case "Drive":
                                if (vehicleType == "Car")
                                {
                                    Console.WriteLine(car.Drive(commandValue));
                                }
                                else if (vehicleType == "Truck")
                                {
                                    Console.WriteLine(truck.Drive(commandValue));
                                }

                                break;
                            case "Refuel":
                                if (vehicleType == "Car")
                                {
                                    car.Refuel(commandValue);
                                }
                                else if (vehicleType == "Truck")
                                {
                                    truck.Refuel(commandValue);
                                }

                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine(car);
            Console.WriteLine(truck);
        }
    }
}
