namespace OOP.Inheritance.Mankind
{
    using System;
    using System.Text;

    public class Worker : Human
    {
        private const string ErrorMessage = "Expected value mismatch! Argument: {0}";
        private decimal weekSalary;
        private int workHoursPerDay;

        public Worker(string firstName, string lastName, decimal weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get => this.weekSalary;
            private set
            {
                if (value <= 10)
                {
                    throw new ArgumentException(string.Format(ErrorMessage, nameof(this.WeekSalary)));
                }

                this.weekSalary = value;
            }
        }

        public int WorkHoursPerDay
        {
            get => this.workHoursPerDay;
            private set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException(string.Format(ErrorMessage, nameof(this.WorkHoursPerDay)));
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal GetMoneyByHour()
        {
            return this.WeekSalary / (this.WorkHoursPerDay * 5);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Week Salary: {this.WeekSalary:F2}");
            sb.AppendLine($"Hours per day: {this.WorkHoursPerDay:F2}");
            sb.AppendLine($"Salary per hour: {this.GetMoneyByHour():F2}");

            return sb.ToString();
        }
    }
}
