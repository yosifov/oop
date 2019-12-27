namespace OOP.Reflection.InfernoInfinity.Models.Weapons
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public class Sword : Weapon
    {
        private const int BaseMinDamage = 4;
        private const int BaseMaxDamage = 6;
        private const int BaseSockets = 3;

        public Sword(string name, Rarity rarity)
            : base(name, BaseMinDamage, BaseMaxDamage, BaseSockets, rarity)
        {
        }
    }
}
