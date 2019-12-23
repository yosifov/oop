namespace OOP.SOLID.Logger.Loggers
{
    public interface ILogFile
    {
        long Size { get; }

        void Write(string message);
    }
}
