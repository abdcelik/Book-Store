using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunum.Models
{
    public class User
    {
        public int userID { get; set; }
        public string name { get; set; }
        public string userName { get; set; }


        public List<Book> CurrSales { get; set; }
        public List<Order> OldSales { get; set; }
        public List<Order> CurrOrder { get; set; }

        

        public User()
        {

        }

        public User(String Name, String Surname, String UserName, int userID)
        {
            this.name = Name;
            this.userName = UserName;
            this.userID = userID;
            CurrSales = new List<Book>();
            OldSales = new List<Order>();
            CurrOrder = new List<Order>();
        }

    }

}