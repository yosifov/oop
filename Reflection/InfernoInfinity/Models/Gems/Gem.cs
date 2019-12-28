namespace OOP.Reflection.InfernoInfinity.Models.Gems
{
    using OOP.Reflection.InfernoInfinity.Contracts;
    using OOP.Reflection.InfernoInfinity.Enums;
    using OOP.Reflection.InfernoInfinity.Utilities;

    public abstract class Gem : IGem
    {
        private int strength;
        private int agility;
        private int vitality;

        public Gem(int strength, int agility, int vitality, Clarity clarity)
        {
            this.Strength = strength;
            this.Agility = agility;
            this.Vitality = vitality;
            this.Clarity = clarity;
        }

        public int Strength
        {
            get => this.strength
                + (int)this.Clarity;
            
            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Strength));

                this.strength = value;
            }
        }

        public int Agility
        {
            get => this.agility
                + (int)Clarity;

            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Agility));

                this.agility = value;
            }
        }

        public int Vitality
        {
            get => this.vitality
                + (int)Clarity;

            protected set
            {
                Validator.ValidateNegative(value, nameof(this.Vitality));

                this.vitality = value;
            }
        }

        public Clarity Clarity { get; protected set; }
    }
}
