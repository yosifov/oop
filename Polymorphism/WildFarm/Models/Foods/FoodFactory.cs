namespace OOP.Polymorphism.WildFarm.Models.Foods
{
    using System;

    public static class FoodFactory
    {
        public static Food Create(params string[] foodArgs)
        {
            Food food;

            string foodType = foodArgs[0];
            int foodQuantity = int.Parse(foodArgs[1]);

            food = foodType switch
            {
                "Vegetable" => new Vegetable(foodQuantity),
                "Fruit" => new Fruit(foodQuantity),
                "Meat" => new Meat(foodQuantity),
                "Seeds" => new Seeds(foodQuantity),
                _ => throw new ArgumentException("Invalid food input")
            };

            return food;
        }
    }
}
