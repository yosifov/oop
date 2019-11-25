namespace OOP.Interfaces.BorderControl
{
    using System;

    public class Rebel : IPerson, IBuyer
    {
        private string name;
        private int age;
        private string group;
        private int food;

        public Rebel(string name, int age, string group)
        {
            this.Name = name;
            this.Age = age;
            this.Id = "0000";
            this.Birthdate = "01/01/1970";
            this.Group = group;
            this.Food = 0;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Name));
                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"{nameof(this.Age)} cannot be negative");
                }

                this.age = value;
            }
        }

        public string Id { get; }

        public string Birthdate { get; }

        public string Group
        {
            get => this.group;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Group));
                this.group = value;
            }
        }

        public int Food
        {
            get => this.food;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid food amount");
                }

                this.food = value;
            }
        }

        public void BuyFood()
        {
            this.Food += 5;
        }
    }
}
