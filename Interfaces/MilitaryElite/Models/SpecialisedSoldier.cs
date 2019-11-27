namespace OOP.Interfaces.MilitaryElite.Models
{
    using System;
    using System.Text;
    using OOP.Interfaces.MilitaryElite.Interfaces;

    public class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private string corps;

        public SpecialisedSoldier(int id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            this.Corps = corps;
        }

        public string Corps 
        { 
            get => this.corps; 
            private set
            {
                if (value.ToLower() != "marines" && value.ToLower() != "airforces")
                {
                    throw new ArgumentException("Invalid corps");
                }

                this.corps = value;
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.Append($"Corps: {this.Corps}");
            return sb.ToString();
        }
    }
}
