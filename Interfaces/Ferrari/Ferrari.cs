namespace OOP.Interfaces.Ferrari
{
    using System.Text;

    public class Ferrari : ICar
    {
        private string model;

        public Ferrari(string driver)
        {
            this.Model = "488-Spider";
            this.Driver = new Driver(driver);
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validation.ValidateIsNull(value, nameof(this.Model));

                this.model = value;
            }
        }

        public Driver Driver { get; }

        public string Brakes()
        {
            return "Brakes!";
        }

        public string GasPedal()
        {
            return "Gas!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append(this.Model);
            sb.Append("/");
            sb.Append(this.Brakes());
            sb.Append("/");
            sb.Append(this.GasPedal());
            sb.Append("/");
            sb.Append(this.Driver.Name);
            return sb.ToString();
        }
    }
}
