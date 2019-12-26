namespace OOP.Inheritance.Animals
{
    using System;
    using System.Collections.Generic;

    public class Startup : IService
    {
        public void Execute()
        {
            var animals = new List<Animal>();

            string input = Console.ReadLine();
            string animalType = null;

            while (input != "Beast!")
            {
                try
                {
                    var animalArgs = input.Split();

                    if (animalArgs.Length == 1)
                    {
                        animalType = animalArgs[0];
                    }
                    else if (animalArgs.Length == 3)
                    {
                        string animalName = animalArgs[0];
                        int animalAge = int.Parse(animalArgs[1]);
                        string animalGender = animalArgs[2];

                        Animal animal = AnimalFactory.GetAnimal(animalType, animalName, animalAge, animalGender);

                        animals.Add(animal);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                input = Console.ReadLine();
            }

            foreach (var animal in animals)
            {
                Console.WriteLine(animal);
            }
        }
    }
}
