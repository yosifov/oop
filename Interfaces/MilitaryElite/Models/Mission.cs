namespace OOP.Interfaces.MilitaryElite.Models
{
    using System;

    public class Mission
    {
        private string codeName;
        private string state;

        public Mission(string codeName, string state)
        {
            this.CodeName = codeName;
            this.State = state;
        }

        public string CodeName 
        {
            get => this.codeName; 
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.CodeName));
                this.codeName = value;
            } 
        }

        public string State
        {
            get => this.state;
            set
            {
                if (value.ToLower() != "inprogress" && value.ToLower() != "finished")
                {
                    throw new ArgumentException("Invalid mission state");
                }

                this.state = value;
            }
        }

        public override string ToString()
        {
            return $"Code Name: {this.CodeName} State: {this.State}";
        }
    }
}
