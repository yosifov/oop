namespace OOP.Polymorphism.WildFarm.Models.Animals
{
    using System;
    using OOP.Polymorphism.WildFarm.Models.Animals.Birds;
    using OOP.Polymorphism.WildFarm.Models.Animals.Mammals;
    using OOP.Polymorphism.WildFarm.Models.Animals.Mammals.Felines;

    public static class AnimalFactory
    {
        public static Animal Create(params string[] animalArgs)
        {
            Animal animal;

            string animalType = animalArgs[0];
            string animalName = animalArgs[1];
            double animalWeight = double.Parse(animalArgs[2]);
            double animalWingSize;
            string animalLivingRegion;
            string animalBreed;

            switch (animalType)
            {
                case "Hen":
                    animalWingSize = double.Parse(animalArgs[3]);
                    animal = new Hen(animalName, animalWeight, animalWingSize);
                    break;
                case "Owl":
                    animalWingSize = double.Parse(animalArgs[3]);
                    animal = new Owl(animalName, animalWeight, animalWingSize);
                    break;
                case "Mouse":
                    animalLivingRegion = animalArgs[3];
                    animal = new Mouse(animalName, animalWeight, animalLivingRegion);
                    break;
                case "Cat":
                    animalLivingRegion = animalArgs[3];
                    animalBreed = animalArgs[4];
                    animal = new Cat(animalName, animalWeight, animalLivingRegion, animalBreed);
                    break;
                case "Dog":
                    animalLivingRegion = animalArgs[3];
                    animal = new Dog(animalName, animalWeight, animalLivingRegion);
                    break;
                case "Tiger":
                    animalLivingRegion = animalArgs[3];
                    animalBreed = animalArgs[4];
                    animal = new Tiger(animalName, animalWeight, animalLivingRegion, animalBreed);
                    break;
                default:
                    throw new ArgumentException("Invalid animal input");
            }

            return animal;
        }
    }
}
