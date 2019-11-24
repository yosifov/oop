namespace OOP.Interfaces.Ferrari
{
    public class Driver
    {
        private string name;

        public Driver(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                Validation.ValidateIsNull(value, nameof(this.Name));

                this.name = value;
            }
        }
    }
}
