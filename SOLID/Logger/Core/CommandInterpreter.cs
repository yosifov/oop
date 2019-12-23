namespace OOP.SOLID.Logger
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using OOP.SOLID.Logger.Appenders;
    using OOP.SOLID.Logger.Core;
    using OOP.SOLID.Logger.Layouts;

    public class CommandInterpreter : ICommandInterpreter
    {
        private IAppendFactory appenderFactory;
        private ILayoutFactory layoutFactory;
        private List<IAppender> appenders;

        public CommandInterpreter()
        {
            this.appenderFactory = new AppenderFactory();
            this.layoutFactory = new LayoutFactory();
            this.appenders = new List<IAppender>();
        }

        public void AddAppender(params string[] appenderArgs)
        {
            IAppender appender = null;
            ILayout layout = null;

            string appenderType;
            string layoutType;
            string reportLevel;

            if (appenderArgs.Length > 1 && appenderArgs.Length < 4)
            {
                appenderType = appenderArgs[0];
                layoutType = appenderArgs[1];

                if (appenderArgs.Length == 3)
                {
                    reportLevel = appenderArgs[2];
                }
                else
                {
                    reportLevel = ReportLevels.INFO.ToString();
                }
            }
            else
            {
                throw new ArgumentException("Invalid appender arguments");
            }

            layout = this.layoutFactory.CreateLayout(layoutType);
            appender = this.appenderFactory.CreateAppender(appenderType, layout);

            if (Enum.TryParse(reportLevel, out ReportLevels level))
            {
                appender.ReportLevel = level;
            }

            this.appenders.Add(appender);
        }

        public void AddMessage(params string[] logArgs)
        {
            string reportLevel;
            string dateTime;
            string message;

            if (logArgs.Length == 3)
            {
                reportLevel = logArgs[0];
                dateTime = logArgs[1];
                message = logArgs[2];
            }
            else
            {
                throw new ArgumentException("Invalid log arguments");
            }

            foreach (var appender in this.appenders)
            {
                appender.Append(dateTime, reportLevel, message);
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine("Logger info");
            foreach (var appender in this.appenders)
            {
                sb.AppendLine(appender.ToString());
            }

            return sb.ToString();
        }
    }
}
