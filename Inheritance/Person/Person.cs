namespace OOP.Inheritance.Person
{
    using System;
    using System.Text;

    public class Person
    {
        private string name;
        private int age;

        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }

        public int Age
        {
            get => this.age;
            protected set
            {
                this.ValidateAge(value);

                this.age = value;
            }
        }

        public string Name
        {
            get => this.name;
            protected set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException($"{this.GetType().Name} name should not be less than 3 symbols!");
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {this.Name}, Age: {this.Age}");

            return sb.ToString();
        }

        protected virtual void ValidateAge(int age)
        {
            if (age < 1)
            {
                throw new ArgumentException($"{this.GetType().Name} must be positive!");
            }
        }
    }
}
