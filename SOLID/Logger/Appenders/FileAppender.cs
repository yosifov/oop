namespace OOP.SOLID.Logger.Appenders
{
    using System;
    using System.IO;
    using OOP.SOLID.Logger.Layouts;
    using OOP.SOLID.Logger.Loggers;

    public class FileAppender : Appender, IAppender
    {
        private const string FilePath = @"..\..\..\..\OOP\SOLID\Logger\log.txt";

        public FileAppender(ILayout layout, LogFile file)
            : base(layout)
        {
            this.LogFile = file;
        }

        public LogFile LogFile { get; protected set; }

        public override void Append(string dateTime, string reportLevel, string message)
        {
            if (Enum.TryParse(reportLevel, out ReportLevels level) && this.ReportLevel <= level)
            {
                using (StreamWriter sw = File.AppendText(FilePath))
                {
                    sw.WriteLine(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                }

                this.LogFile.Write(string.Format(this.Layout.Format, dateTime, reportLevel, message));
                this.MessageCount++;
            }
        }

        public override string ToString()
        {
            return base.ToString() + $"File size: {this.LogFile.Size}";
        }
    }
}
