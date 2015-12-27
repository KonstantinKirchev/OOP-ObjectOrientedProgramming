using System;
using System.Text;

namespace Problem1.BookShop
{
    public class Book
    {
        private string title;
        private string author;
        private decimal price;

        public Book(string title, string author, decimal price)
        {
            this.Title = title;
            this.Author = author;
            this.Price = price;
        }

        public string Title
        {
            get
            {
                return this.title;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value","Title cannot be null or empty.");
                }

                this.title = value;
            }
        }

        public string Author {
            get
            {
                return this.author;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("value", "Author cannot be null or empty.");
                }

                this.author = value;
            }
        }

        public virtual decimal Price {
            get
            {
                return this.price;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Price cannot be negative.");
                }

                this.price = value;
            }
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("-Type: {0}{1}", GetType().Name, Environment.NewLine);
            output.AppendFormat("-Title: {0}{1}", this.Title, Environment.NewLine);
            output.AppendFormat("-Author: {0}{1}", this.Author, Environment.NewLine);
            output.AppendFormat("-Price: {0:F2}{1}", this.Price, Environment.NewLine);
            //return string.Format("-Type: {0}\n-Title: {1}\n-Author: {2}\n-Price: {3:F2}\n", GetType().Name, Title, Author, Price);
            return output.ToString();
        }
    }
}
