﻿namespace OOP.Inheritance.Animals
{
    using System;
    using OOP.Inheritance.Animals.Animals;

    public static class AnimalFactory
    {
        public static Animal GetAnimal(string type, string name, int age, string gender)
        {
            switch (type)
            {
                case "Dog":
                    return new Dog(name, age, gender);
                case "Cat":
                    return new Cat(name, age, gender);
                case "Frog":
                    return new Frog(name, age, gender);
                case "Kitten":
                    return new Kitten(name, age, gender);
                case "Tomcat":
                    return new Tomcat(name, age, gender);
                default:
                    throw new ArgumentException("Invalid animal type!");
            }
        }
    }
}
