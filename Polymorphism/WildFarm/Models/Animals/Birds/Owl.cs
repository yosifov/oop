namespace OOP.Polymorphism.WildFarm.Models.Animals.Birds
{
    using System;
    using System.Collections.Generic;
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public class Owl : Bird
    {
        private readonly List<string> foodThatEat = new List<string>()
        {
            nameof(Meat)
        };

        public Owl(string name, double weight, double wingSize)
            : base(name, weight, wingSize)
        {
        }

        protected override double WeightIndex => 0.25;

        public override string ProduceSound()
        {
            return "Hoot Hoot";
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
