namespace OOP.Inheritance.Animals
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public abstract class Animal
    {
        private const string ErrorMessage = "Invalid input!";
        private string name;
        private int age;
        private string gender;
        private List<string> genders = new List<string>()
        {
            "male",
            "female"
        };

        public string Name
        {
            get => this.name;
            protected set
            {
                ValidateNotNull(value);

                this.name = value;
            }
        }

        public int Age
        {
            get => this.age;
            protected set
            {
                ValidateNotNull(value.ToString());
                if (value < 1)
                {
                    throw new ArgumentException(ErrorMessage);
                }

                this.age = value;
            }
        }

        public string Gender
        {
            get => this.gender;
            protected set
            {
                if (!this.genders.Contains(value.ToLower()))
                {
                    throw new ArgumentException(ErrorMessage);
                }

                this.gender = value;
            }
        }

        public abstract string ProduceSound();

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine(this.ProduceSound());
            return sb.ToString().TrimEnd();
        }

        private static void ValidateNotNull(string value)
        {
            if (string.IsNullOrEmpty(value) && string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMessage);
            }
        }
    }
}