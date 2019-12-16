namespace OOP.Polymorphism.WildFarm
{
    using System;
    using System.Collections.Generic;
    using OOP.Polymorphism.WildFarm.Models.Animals;
    using OOP.Polymorphism.WildFarm.Models.Animals.Birds;
    using OOP.Polymorphism.WildFarm.Models.Animals.Mammals.Felines;
    using OOP.Polymorphism.WildFarm.Models.Animals.Mammals;
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public class Startup
    {
        public static void Execute()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] animalArgs = input.Split();

                    string animalType = animalArgs[0];
                    string animalName = animalArgs[1];
                    double animalWeight = double.Parse(animalArgs[2]);
                    double animalWingSize;
                    string animalLivingRegion;
                    string animalBreed;
                    Animal currentAnimal = null;
                    Food currentFood = null;

                    switch (animalType)
                    {
                        case "Hen":
                            animalWingSize = double.Parse(animalArgs[3]);
                            currentAnimal = new Hen(animalName, animalWeight, animalWingSize);
                            break;
                        case "Owl":
                            animalWingSize = double.Parse(animalArgs[3]);
                            currentAnimal = new Owl(animalName, animalWeight, animalWingSize);
                            break;
                        case "Mouse":
                            animalLivingRegion = animalArgs[3];
                            currentAnimal = new Mouse(animalName, animalWeight, animalLivingRegion);
                            break;
                        case "Cat":
                            animalLivingRegion = animalArgs[3];
                            animalBreed = animalArgs[4];
                            currentAnimal = new Cat(animalName, animalWeight, animalLivingRegion, animalBreed);
                            break;
                        case "Dog":
                            animalLivingRegion = animalArgs[3];
                            currentAnimal = new Dog(animalName, animalWeight, animalLivingRegion);
                            break;
                        case "Tiger":
                            animalLivingRegion = animalArgs[3];
                            animalBreed = animalArgs[4];
                            currentAnimal = new Tiger(animalName, animalWeight, animalLivingRegion, animalBreed);
                            break;
                        default:
                            throw new ArgumentException("Invalid animal input");
                    }

                    Console.WriteLine(currentAnimal.ProduceSound());

                    string[] foodArgs = Console.ReadLine().Split();
                    string foodType = foodArgs[0];
                    int foodQuantity = int.Parse(foodArgs[1]);

                    switch (foodType)
                    {
                        case "Vegetable":
                            currentFood = new Vegetable(foodQuantity);
                            break;
                        case "Fruit":
                            currentFood = new Fruit(foodQuantity);
                            break;
                        case "Meat":
                            currentFood = new Meat(foodQuantity);
                            break;
                        case "Seeds":
                            currentFood = new Seeds(foodQuantity);
                            break;
                        default:
                            throw new ArgumentException("Invalid food input");
                    }

                    currentAnimal.Eat(currentFood);
                    animals.Add(currentAnimal);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
