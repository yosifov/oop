namespace OOP.SOLID.Logger.Appenders
{
    using OOP.SOLID.Logger.Layouts;

    public abstract class Appender : IAppender
    {
        public Appender(ILayout layout)
        {
            this.Layout = layout;
            this.ReportLevel = ReportLevels.INFO;
            this.MessageCount = 0;
        }

        public ILayout Layout { get; protected set; }

        public ReportLevels ReportLevel { get; set; }

        public int MessageCount { get; protected set; }

        public abstract void Append(string dateTime, string reportLevel, string message);

        public override string ToString()
        {
            return $"Appender type: {this.GetType().Name}, " +
                    $"Layout type: {this.Layout.GetType().Name}, " +
                    $"Report level: {this.ReportLevel.ToString().ToUpper()}, " +
                    $"Messages appended: {this.MessageCount}";
        }
    }
}
