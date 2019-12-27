namespace OOP.Reflection.InfernoInfinity.Models.Gems
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public class Ruby : Gem
    {
        private const int BaseStrength = 7;
        private const int BaseAgility = 2;
        private const int BaseVitality = 5;

        public Ruby(Clarity clarity) 
            : base(BaseStrength, BaseAgility, BaseVitality, clarity)
        {
        }
    }
}
