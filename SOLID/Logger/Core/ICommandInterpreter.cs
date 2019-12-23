namespace OOP.SOLID.Logger.Core
{
    public interface ICommandInterpreter
    {
        void AddAppender(params string[] appenderArgs);

        void AddMessage(params string[] logArgs);
    }
}
