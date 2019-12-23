namespace OOP.SOLID.Logger.Layouts
{
    using System;
    
    public class LayoutFactory : ILayoutFactory
    {
        public ILayout CreateLayout(string type)
        {
            switch (type.ToLower())
            {
                case "simplelayout":
                    return new SimpleLayout();
                case "newlinelayout":
                    return new NewLineLayout();
                case "xmllayout":
                    return new XmlLayout();
                default:
                    throw new ArgumentException("Invalid layout type");
            }
        }
    }
}
