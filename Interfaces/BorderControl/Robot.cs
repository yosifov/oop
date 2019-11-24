namespace OOP.Interfaces.BorderControl
{
    public class Robot : IRobot
    {
        private string model;
        private string id;

        public Robot(string model, string id)
        {
            this.Model = model;
            this.Id = id;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Model));
                this.model = value;
            }
        }

        public string Id
        {
            get => this.id;
            private set
            {
                Validator.ValidateNotNull(value, nameof(this.Id));
                Validator.ValidateOnlyDigits(value, nameof(this.id));
                this.id = value;
            }
        }
    }
}
