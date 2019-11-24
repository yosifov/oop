namespace OOP.Interfaces.BorderControl
{
    using System;

    public class Citizen : IPerson
    {
        private string name;
        private int age;
        private string id;

        public Citizen(string name, int age, string id)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
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

        public string Id
        {
            get => this.id;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Id));
                Validator.ValidateOnlyDigits(value, nameof(this.id));
                this.id = value;
            }
        }
    }
}
