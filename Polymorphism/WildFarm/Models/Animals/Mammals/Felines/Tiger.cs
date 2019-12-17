namespace OOP.Polymorphism.WildFarm.Models.Animals.Mammals.Felines
{
    using System;
    using System.Collections.Generic;
    using OOP.Polymorphism.WildFarm.Models.Foods;

    public class Tiger : Feline
    {
        private List<string> foodThatEat = new List<string>()
        {
            nameof(Meat)
        };

        public Tiger(string name, double weight, string livingRegion, string breed)
            : base(name, weight, livingRegion, breed)
        {
        }

        protected override double WeightIndex => 1.00;

        public override string ProduceSound()
        {
            return "ROAR!!!";
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
