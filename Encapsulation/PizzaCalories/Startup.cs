namespace OOP.Encapsulation.PizzaCalories
{
    using System;

    public class Startup
    {
        public static void Execute()
        {
            var pizzaParameters = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            string pizzaName = pizzaParameters[1];

            var doughParameters = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);

            string flourType = doughParameters[1];
            string bakingTechnique = doughParameters[2];
            int doughWeight = int.Parse(doughParameters[3]);

            var dough = new Dough(flourType, bakingTechnique, doughWeight);
            var pizza = new Pizza(pizzaName, dough);

            var input = Console.ReadLine();
            while (input != "END")
            {
                var parameters = input.Split();
                var inputType = parameters[0];

                if (inputType.Equals("Topping"))
                {
                    string type = parameters[1];
                    int toppingWeight = int.Parse(parameters[2]);

                    try
                    {
                        var topping = new Topping(type, toppingWeight);
                        pizza.AddTopping(topping);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }

                input = Console.ReadLine();
            }

            Console.WriteLine(pizza);
        }
    }
}
