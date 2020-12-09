using System;
using System.Collections.Generic;

namespace Fusion.Entity
{
    public class User : Person
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual List<Book> CurrSales { get; set; }
        public virtual List<Order> OldSales { get; set; }
        public virtual List<Order> CurrOrder { get; set; }

        public User(String UserName, String Password, String Name, String Surname) : base(Name,Surname)
        {
            this.UserName = UserName;
            this.Password = Password;
            Cart = new Cart();
            CurrSales = new List<Book>();
            OldSales = new List<Order>();
            CurrOrder = new List<Order>();
        }

        public void BuyCart()
        {
            // TO DO
        }

        public void AddBookToCart(Book book) { Cart.AddBook(book); }

        public bool RemoveBookFromCart(Book book) { return Cart.RemoveBook(book); }

        public override String ToString() { return String.Format("{0}UserName: {1}\nPassword: {2}\n", base.ToString(), UserName, Password); }
    }
}