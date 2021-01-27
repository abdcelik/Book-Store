using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sunum.Models
{
    public class Order
    {
        public User User { get; set; }

        public Book Book { get; set; }
    }
}