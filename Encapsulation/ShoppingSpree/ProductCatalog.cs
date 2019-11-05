namespace OOP.Encapsulation.ShoppingSpree
{
    using System;
    using System.Collections.Generic;

    public class ProductCatalog
    {
        private List<Product> catalog;

        public ProductCatalog()
        {
            this.catalog = new List<Product>();
        }

        public IReadOnlyList<Product> Catalog 
        {
            get => this.catalog; 
        }

        public void AddMany(string[] parameters)
        {
            foreach (var parameter in parameters)
            {
                var product = parameter.Split("=");
                if (product.Length == 2)
                {
                    string productName = product[0];
                    decimal productCost = decimal.Parse(product[1]);
                    try
                    {
                        this.catalog.Add(new Product(productName, productCost));
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine(e.Message);
                        return;
                    }
                }
            }
        }
    }
}
