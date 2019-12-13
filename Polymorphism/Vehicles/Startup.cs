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
            Bus bus = null;
            double fuelQuantity;
            double fuelConsumptionPerKm;
            double tankCapacity;

            while (true)
            {
                string[] carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = carInfo[0];

                if (vehicleType != "Car")
                {
                    Console.WriteLine("Invalid Car input. Try again:");
                    continue;
                }
                else
                {
                    try
                    {

                        fuelQuantity = double.Parse(carInfo[1]);
                        fuelConsumptionPerKm = double.Parse(carInfo[2]);
                        tankCapacity = double.Parse(carInfo[3]);

                        car = new Car(tankCapacity, fuelQuantity, fuelConsumptionPerKm, true, false);
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
                string[] truckInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = truckInfo[0];

                if (vehicleType != "Truck")
                {
                    Console.WriteLine("Invalid Truck input. Try again:");
                    continue;
                }
                else
                {
                    try
                    {
                        fuelQuantity = double.Parse(truckInfo[1]);
                        fuelConsumptionPerKm = double.Parse(truckInfo[2]);
                        tankCapacity = double.Parse(truckInfo[3]);

                        truck = new Truck(tankCapacity, fuelQuantity, fuelConsumptionPerKm, true, true);
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
                string[] busInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string vehicleType = busInfo[0];

                if (vehicleType != "Bus")
                {
                    Console.WriteLine("Invalid Bus input. Try again:");
                    continue;
                }
                else
                {
                    try
                    {
                        fuelQuantity = double.Parse(busInfo[1]);
                        fuelConsumptionPerKm = double.Parse(busInfo[2]);
                        tankCapacity = double.Parse(busInfo[3]);

                        bus = new Bus(tankCapacity, fuelQuantity, fuelConsumptionPerKm, true, false);
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
                    string[] commands = Console.ReadLine()
                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                    if (commands.Length != 3)
                    {
                        Console.WriteLine("Wrong action");
                    }
                    else
                    {
                        string commandType = commands[0];
                        string vehicleType = commands[1];
                        double commandValue = double.Parse(commands[2]);

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
                                else if (vehicleType == "Bus")
                                {
                                    Console.WriteLine(bus.Drive(commandValue));
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
                                else if (vehicleType == "Bus")
                                {
                                    bus.Refuel(commandValue);
                                }

                                break;
                            case "DriveEmpty":
                                if (vehicleType == "Bus")
                                {
                                    Console.WriteLine(bus.DriveEmpty(commandValue));
                                }
                                break;
                            default:
                                Console.WriteLine("Wrong action");
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
            Console.WriteLine(bus);
        }
    }
}
