namespace OOP.Events.KingsGambit.Contracts
{
    public interface IHeroFactory
    {
        IPerson Create(string type, string name);
    }
}
