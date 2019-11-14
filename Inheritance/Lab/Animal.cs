namespace OOP.Inheritance.Lab
{
    using System;

    public class Animal
    {
        private string name;

        public Animal(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            protected set 
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException($"{this.GetType().Name} name cannot be empty.");
                }
                
                this.name = value; 
            }
        }

        public string Eat()
        {
            return $"{this.Name} is eating...";
        }
    }
}
