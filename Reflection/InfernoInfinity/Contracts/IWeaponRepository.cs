namespace OOP.Reflection.InfernoInfinity.Contracts
{
    public interface IWeaponRepository
    {
        void AddWeapon(IWeapon weapon);

        void AddGemToWeapon(string weaponName, int gemIndex, IGem gem);

        void RemoveGemFromWeapon(string weaponName, int gemIndex);

        string PrintWeapon(string weaponName);

        string PrintAllWeapons();
    }
}
