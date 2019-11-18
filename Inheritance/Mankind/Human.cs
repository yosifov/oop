namespace OOP.Inheritance.Mankind
{
    using System;
    using System.Text;

    public class Human
    {
        private const int FirstNameMinLength = 4;
        private const int LastNameMinLength = 3;
        private string firstName;
        private string lastName;

        public Human(string firstName, string lastName)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }

        public string FirstName
        {
            get => this.firstName;
            protected set
            {
                this.ValidateFirstLetter(value, nameof(this.FirstName));
                this.ValidateLength(value, FirstNameMinLength, nameof(this.FirstName));

                this.firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            protected set 
            {
                this.ValidateFirstLetter(value, nameof(this.LastName));
                this.ValidateLength(value, LastNameMinLength, nameof(this.LastName));

                this.lastName = value; 
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine($"FisrtName: {this.FirstName}");
            sb.AppendLine($"LastName: {this.LastName}");

            return sb.ToString().TrimEnd();
        }

        private void ValidateFirstLetter(string value, string propertyName)
        {
            if (char.IsLower(value[0]))
            {
                throw new ArgumentException($"Expected upper case letter! Argument: {propertyName}");
            }
        }

        private void ValidateLength(string value, int minLength, string propertyName)
        {
            if (value.Length < minLength)
            {
                throw new ArgumentException($"Expected length at least {minLength} symbols! Argument: {propertyName}");
            }
        }
    }
}
