namespace OOP.SOLID.Logger.Appenders
{
    using System;
    using OOP.SOLID.Logger.Layouts;

    public class ConsoleAppender : Appender, IAppender
    {
        public ConsoleAppender(ILayout layout)
            : base(layout)
        {
        }

        public override void Append(string dateTime, string reportLevel, string message)
        {
            if (Enum.TryParse(reportLevel, out ReportLevels level) && this.ReportLevel <= level)
            {
                Console.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessageCount++;
            }
        }
    }
}
