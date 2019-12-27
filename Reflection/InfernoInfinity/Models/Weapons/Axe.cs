namespace OOP.Reflection.InfernoInfinity.Models.Weapons
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public class Axe : Weapon
    {
        private const int BaseMinDamage = 5;
        private const int BaseMaxDamage = 10;
        private const int BaseSockets = 4;

        public Axe(string name, Rarity rarity)
            : base(name, BaseMinDamage, BaseMaxDamage, BaseSockets, rarity)
        {
        }
    }
}
