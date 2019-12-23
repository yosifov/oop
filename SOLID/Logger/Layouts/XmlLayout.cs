namespace OOP.SOLID.Logger.Layouts
{
    public class XmlLayout : ILayout
    {
        public string Format => "<log>\n" +
                "\t<date>{0}</date>\n" +
                "\t<level>{1}</level>\n" +
                "\t<message>{2}</message>\n" +
                "</log>";
    }
}
