using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookStore.Entity
{
    public class User : EntityBase
    {
        public string Username { get; set; }

        public string Password { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public string Address { get; set; }

        public string Phonenumber { get; set; }

        public virtual Cart Cart { get; set; }

        public virtual List<Book> CurrSales { get; set; }

        public virtual List<Order> OldSales { get; set; }

        public virtual List<Order> CurrOrder { get; set; }

    }
}
