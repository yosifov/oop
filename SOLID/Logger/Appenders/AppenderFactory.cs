namespace OOP.SOLID.Logger.Appenders
{
    using System;
    using OOP.SOLID.Logger.Layouts;
    using OOP.SOLID.Logger.Loggers;

    public class AppenderFactory : IAppendFactory
    {
        public IAppender CreateAppender(string type, ILayout layout)
        {
            switch (type.ToLower())
            {
                case "consoleappender":
                    return new ConsoleAppender(layout);
                case "fileappender":
                    return new FileAppender(layout, new LogFile());
                default:
                    throw new ArgumentException("Invalid appender type");
            }
        }
    }
}
