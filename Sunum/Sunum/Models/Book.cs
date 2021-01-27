using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunum.Models
{
    public class Book
    {
        public int productID { get; set;}

        public string name { get; set; }

        public string author { get; set; }

        public double price { get; set; }

        public string imageUrl { get; set; }

        public List<Tag> tags { get; set; }

        public string summary { get; set; }

        public User user { get; set; }

        public Book()
        {
        
        }

        public Book(int productID_, string name_, double price_, string author_, string photourl_, User user_, List<Tag> tags_, string summary_)
        {
            this.productID = productID_;
            this.name = name_;
            this.author = author_;
            this.price = price_;
            this.imageUrl = photourl_;
            this.user = user_;
            this.tags = tags_;
            this.summary = summary_;
        }
    }
}