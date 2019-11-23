namespace OOP.Interfaces.IPerson
{
    using System;

    public class Citizen : IPerson, IBirthable, IIdentifiable
    {
        private string name;
        private int age;
        private string id;
        private string birthdate;

        public Citizen(string name, int age, string id, string birthdate)
        {
            this.Name = name;
            this.Age = age;
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                ValidateNotNull(value, nameof(this.name));

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
                    throw new ArgumentException($"Invalid {nameof(this.age)}");
                }

                this.age = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                ValidateNotNull(value, nameof(this.id));

                this.id = value;
            }
        }

        public string Birthdate
        {
            get => this.birthdate;
            private set
            {
                ValidateNotNull(value, nameof(this.birthdate));

                this.birthdate = value;
            }
        }

        private static void ValidateNotNull(string value, string type)
        {
            if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException($"Invalid {type}");
            }
        }
    }
}
