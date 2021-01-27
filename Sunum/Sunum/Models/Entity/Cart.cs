using System.Collections.Generic;

namespace FusionBookieDB.Entity
{
    public class Cart : EntityBase
    {
        public virtual List<CartItem> CartItems { get; set; }
        public double Price { get; set; }

        public Cart() {

        }

        public void AddBook(Book book)
        {
            CartItem NewBook = new CartItem(book);
            CartItems.Add(NewBook);
            Price += book.Price;
        }

        public bool RemoveBook(Book book)
        {
            //TODO
            return false;
        }

        
    }
}