namespace OOP.Inheritance.RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        private Random random;

        public RandomList()
        {
            this.random = new Random();
        }
        public string RandomString()
        {
            int randomIndex = this.random.Next(0, this.Count);
            string randomString = this[randomIndex];
            this.RemoveAt(randomIndex);
            return randomString;
        }
    }
}
