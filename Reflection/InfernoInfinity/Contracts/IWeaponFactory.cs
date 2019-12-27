namespace OOP.Reflection.InfernoInfinity.Contracts
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public interface IWeaponFactory
    {
        IWeapon CreateWeapon(string weaponType, string name, Rarity rarity);
    }
}
