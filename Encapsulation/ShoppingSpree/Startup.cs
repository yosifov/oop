namespace OOP.Encapsulation.ShoppingSpree
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            var shoppers = new Shoppers();
            var products = new ProductCatalog();

            var peopleParameters = Console.ReadLine().Split(";");
            var productsParameters = Console.ReadLine().Split(";");

            shoppers.AddMany(peopleParameters);
            products.AddMany(productsParameters);
            
            var input = Console.ReadLine();

            while (input != "END")
            {
                var parameters = input.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                shoppers.BuyProduct(parameters, products);
                input = Console.ReadLine();
            }

            shoppers.Print();
        }
    }
}
