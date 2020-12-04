using System;
using System.Collections.Generic;
using System.Text;

namespace Fusion
{
    class User : Person
    {
        public String password { get; set; }
        public String address { get; set; } = "-";
        public String phoneNumber { get; set; } = "-";
        public Basket basket { get; }

        public User(String name, String surname, int ID, String password) : base(name,surname,ID)
        {
            basket = new Basket();
            this.password = password;
        }

        public void buyBasket() { /* TODO */ }

        public void addBookToBasket(Book book) { basket.addBook(book); }

        public bool removeBookFromBasket(Book book) { return basket.removeBook(book); }

        public override string ToString() { return String.Format("{0}Password: {1}\nAddress: {2}\nPhone Number: {3}\n",base.ToString(),password,address,phoneNumber); }
        
    }
}
