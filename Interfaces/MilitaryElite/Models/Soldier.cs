namespace OOP.Interfaces.MilitaryElite.Models
{
    using System;
    using OOP.Interfaces.MilitaryElite.Interfaces;

    public class Soldier : ISoldier
    {
        private int id;
        private string firstName;
        private string lastName;

        public Soldier(int id, string firstName, string lastName)
        {
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public int Id
        {
            get => this.id;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Invalid {this.GetType().Name} {nameof(this.id)}");
                }

                this.id = value;
            }
        }

        public string FirstName
        {
            get => this.firstName;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.FirstName));
                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.LastName));
                this.lastName = value;
            }
        }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
