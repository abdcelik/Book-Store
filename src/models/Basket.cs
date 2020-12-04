using System;
using System.Collections.Generic;
using System.Text;

namespace Fusion
{
    class Basket
    {
        public List<Book> book { get; private set; }
        public int totalPrice { get; set; }

        public Basket() { book = new List<Book>(0); }

        public void addBook(Book book)
        {
            this.book.Add(book);
            totalPrice += book.price;
        }

        public bool removeBook(Book book)
        {
            bool res;

            if ((res = this.book.Remove(book)))
                totalPrice -= book.price;
            return res;
        }
    }
}
