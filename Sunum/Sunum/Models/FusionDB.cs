using FusionBookieDB.Entity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookieDB
{
    public class FusionDb : DbContext
    {
        public FusionDb() : base(@"Data Source=.\SQLEXPRESS;Initial Catalog=BookieDB;Integrated Security=True")
        {

        }

        public DbSet<User> Users { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<Cart> Carts { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<CartItem> CartItems { get; set; }

    }
}
