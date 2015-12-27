namespace Problem1.BookShop
{
    public class GoldenEditionBook : Book
    {
        private decimal price;

        public GoldenEditionBook(string title, string author, decimal price) 
            : base(title, author, price)
        {
        }

        public override decimal Price
        {
            get { return this.price; }
            set { this.price = value * 1.30m; }
        }
    }
}
