namespace OOP.Inheritance.RandomList
{
    using System;
    using System.Collections.Generic;

    public class RandomList : List<string>
    {
        public void RandomString()
        {
            var random = new Random();
            var randomIndex = random.Next(0, this.Count);
            this.RemoveAt(randomIndex);
        }
    }
}
