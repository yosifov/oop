﻿namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public class Mouse : Mammal
    {
        private readonly List<string> foodThatEat = new List<string>()
        {
            nameof(Vegetable),
            nameof(Fruit)
        };

        public Mouse(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightIndex => 0.10;

        public override string ProduceSound()
        {
            return "Squeak";
        }

        public override void Eat(Food food)
        {
            if (this.foodThatEat.Contains(food.GetType().Name))
            {
                base.Eat(food);
            }
            else
            {
                Console.WriteLine($"{this.GetType().Name} does not eat {food.GetType().Name}!");
            }
        }
    }
}
