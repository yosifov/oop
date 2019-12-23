namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals
{
    using System;
    using System.Collections.Generic;
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public class Dog : Mammal
    {
        private readonly List<string> foodThatEat = new List<string>()
        {
            nameof(Meat)
        };

        public Dog(string name, double weight, string livingRegion)
            : base(name, weight, livingRegion)
        {
        }

        protected override double WeightIndex => 0.40;

        public override string ProduceSound()
        {
            return "Woof!";
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
