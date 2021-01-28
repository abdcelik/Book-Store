using System;
using System.Collections.Generic;

namespace FusionBookieDB.Entity
{
    public class User : Person
    {
        public String UserName { get; set; }
        public String Password { get; set; }
        public virtual Cart Cart { get; set; }
        public virtual List<Book> CurrSales { get; set; }
        public virtual List<Order> OldSales { get; set; }
        public virtual List<Order> CurrOrder { get; set; }
        public String email { get; set; }

        public User()
        {

        }

        public User(String UserName, String Password, String Name, String Surname) : base(Name, Surname)
        {
            this.UserName = UserName;
            this.Password = Password;
            Cart = new Cart();
            CurrSales = new List<Book>();
            OldSales = new List<Order>();
            CurrOrder = new List<Order>();
        }

        public User(String Username, String Email, String PhoneNumber, String Name, String Surname, String Address, String Password) : this(Username, Password, Name, Surname)
        {
            this.email = Email;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
        }

        public void BuyCart()
        {
            // TODO
        }

        //?
        public void UpdateUser()
        {
            //TODO
        }

        public void AddSale()
        {
            //TODO
        }

        public void AddBookToCart(Book book) { Cart.AddBook(book); }

        public bool RemoveBookFromCart(Book book) { return Cart.RemoveBook(book); }

        public override String ToString() { return String.Format("{0}UserName: {1}\nPassword: {2}\n", base.ToString(), UserName, Password); }

        public List<string> GetUserInfo()
        {
            //TODO

            return null;
        }
    }
}