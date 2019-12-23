namespace OOP.SOLID.Logger.Layouts
{
    public class NewLineLayout : ILayout
    {
        public string Format => "Date: {0}\n" +
            "Report level: {1}\n" +
            "Message: {2}";
    }
}
