namespace OOP.SOLID.Logger.Loggers
{
    using OOP.SOLID.Logger.Appenders;

    public class Logger : ILogger
    {
        private IAppender[] appenders;

        public Logger(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }

        public void Critical(string dateTime, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, ReportLevels.CRITICAL.ToString(), message);
            }
        }

        public void Error(string dateTime, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, ReportLevels.ERROR.ToString(), message);
            }
        }

        public void Fatal(string dateTime, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, ReportLevels.FATAL.ToString(), message);
            }
        }

        public void Info(string dateTime, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, ReportLevels.INFO.ToString(), message);
            }
        }

        public void Warning(string dateTime, string message)
        {
            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, ReportLevels.WARNING.ToString(), message);
            }
        }
    }
}
