namespace OOP.SOLID.Logger.Appenders
{
    using OOP.SOLID.Logger.Layouts;

    public interface IAppender
    {
        ILayout Layout { get; }

        ReportLevels ReportLevel { get; set; }

        int MessageCount { get; }

        void Append(string dateTime, string reportLevel, string message);
    }
}
