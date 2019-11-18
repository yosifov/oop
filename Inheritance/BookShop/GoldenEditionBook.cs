namespace OOP.Inheritance.BookShop
{
    public class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price)
            : base(author, title, price)
        {
        }

        public override decimal Price 
        { 
            get => base.Price; 
            protected set => base.Price = value + (value * 0.30m); 
        }
    }
}
