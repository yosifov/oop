namespace OOP.Polymorphism.WildFarm
{
    using System;
    using System.Collections.Generic;
    using OOP.Polymorphism.WildFarm.Models.Animals;
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public class Startup : IService
    {
        public void Execute()
        {
            List<Animal> animals = new List<Animal>();

            string input = Console.ReadLine();

            while (input != "End")
            {
                try
                {
                    string[] animalArgs = input.Split();

                    Animal animal = AnimalFactory.Create(animalArgs);

                    Console.WriteLine(animal.ProduceSound());

                    string[] foodArgs = Console.ReadLine().Split();

                    Food food = FoodFactory.Create(foodArgs);

                    animal.Eat(food);
                    animals.Add(animal);
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
