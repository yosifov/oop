namespace OOP.Inheritance.Mankind
{
    using System;
    using System.Linq;
    using System.Text;

    public class Student : Human
    {
        private const string ErrorMessage = "Invalid faculty number!";
        private string facultyNumber;

        public Student(string firstName, string lastName, string facultyNumber)
            : base(firstName, lastName)
        {
            this.FacultyNumber = facultyNumber;
        }

        public string FacultyNumber
        {
            get => this.facultyNumber;
            private set
            {
                this.ValidateFacultyNumber(value);

                this.facultyNumber = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"FacultyNumber: {this.FacultyNumber}");

            return sb.ToString();
        }

        private void ValidateFacultyNumber(string number)
        {
            if (number.Length < 5 || number.Length > 10)
            {
                throw new ArgumentException(ErrorMessage);
            }

            if (!number.All(x => char.IsLetterOrDigit(x)))
            {
                throw new ArgumentException(ErrorMessage);
            }
        }
    }
}
