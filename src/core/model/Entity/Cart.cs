using System.Collections.Generic;

namespace Fusion.Entity
{
    public class Cart : EntityBase
    {
        public virtual List<Book> Books { get; set; }
        public double Price { get; set; }

        public Cart() { Books = new List<Book>(); }

        public void AddBook(Book book)
        {
            Books.Add(book);
            Price += book.Price;
        }

        public bool RemoveBook(Book book)
        {
            bool res;

            if ((res = Books.Remove(book)))
                Price -= book.Price;
            return res;
        }
    }
}