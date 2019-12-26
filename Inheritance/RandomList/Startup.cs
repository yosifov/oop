namespace OOP.Inheritance.RandomList
{
    using System;

    public class Startup : IService
    {
        public void Execute()
        {
            var randomList = new RandomList();

            randomList.Add("First");
            randomList.Add("Second");
            randomList.Add("Third");

            Console.WriteLine(randomList.RandomString());

            Console.WriteLine(string.Join(", ", randomList));
        }
    }
}