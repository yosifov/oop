namespace OOP.SOLID.Logger.Layouts
{
    public interface ILayoutFactory
    {
        ILayout CreateLayout(string type);
    }
}
