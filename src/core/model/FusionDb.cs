using FusionBookStore.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookStore
{
    class FusionDb : DbContext
    {
        public FusionDb()
            : base(@"Data Source=.\sqlexpress;Initial Catalog=FusionDb;Integrated Security=True")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Order> Orders { get; set; }


    }
}
