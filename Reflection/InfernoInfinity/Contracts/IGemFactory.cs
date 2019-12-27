namespace OOP.Reflection.InfernoInfinity.Contracts
{
    using OOP.Reflection.InfernoInfinity.Enums;

    public interface IGemFactory
    {
        IGem CreateGem(string gemType, Clarity clarity);
    }
}
