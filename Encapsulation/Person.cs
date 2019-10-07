namespace OOP.Encapsulation
{
    using System;

    public class Person
    {
        private string firstName;

        private string lastName;

        private int age;

        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        public Person(string firstName, string lastName, int age)
            : this(firstName, lastName, age, 0)
        {
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                this.ValidateFirstName(value);
                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                this.ValidateLastName(value);
                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                this.ValidateAge(value);
                this.age = value;
            }
        }

        public decimal Salary
        {
            get
            {
                return this.salary;
            }

            private set
            {
                this.ValidateSalary(value);
                this.salary = value;
            }
        }

        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age < 30)
            {
                percentage /= 2;
            }

            this.Salary += this.Salary * percentage / 100;
        }

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary:F2} leva.";
        }

        private void ValidateSalary(decimal salary)
        {
            if (salary < 460)
            {
                throw new ArgumentException("Salary cannot be less than 460 leva!");
            }
        }

        private void ValidateAge(int age)
        {
            if (age <= 0)
            {
                throw new ArgumentException("Age cannot be zero or a negative integer!");
            }
        }

        private void ValidateFirstName(string firstName)
        {
            if (firstName.Length < 3)
            {
                throw new ArgumentException($"{nameof(this.FirstName)} cannot contain fewer than 3 symbols!");
            }
        }

        private void ValidateLastName(string lastName)
        {
            if (lastName.Length < 3)
            {
                throw new ArgumentException($"{nameof(this.LastName)} cannot contain fewer than 3 symbols!");
            }
        }
    }
}