namespace OOP.Inheritance.RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        public string RandomString()
        {
            var random = new Random();
            var randomIndex = random.Next(0, this.Count);
            string randomString = this[randomIndex];
            this.RemoveAt(randomIndex);
            return randomString;
        }
    }
}
