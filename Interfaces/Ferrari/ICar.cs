namespace OOP.Interfaces.Ferrari
{
    public interface ICar
    {
        public string Model { get; }

        public Driver Driver { get; }

        string Brakes();

        string GasPedal();
    }
}
