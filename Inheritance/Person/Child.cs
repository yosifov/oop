namespace OOP.Inheritance.Person
{
    using System;

    public class Child : Person
    {
        public Child(string name, int age)
            : base(name, age)
        {
        }

        protected override void ValidateAge(int age)
        {
            if (age < 1 || age > 15)
            {
                throw new ArgumentException($"{this.GetType().Name} age must be i range [0..15] years.");
            }
        }
    }
}
