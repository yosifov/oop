namespace OOP.SOLID.Logger.Appenders
{
    using OOP.SOLID.Logger.Layouts;

    public interface IAppendFactory
    {
        IAppender CreateAppender(string type, ILayout layout);
    }
}
