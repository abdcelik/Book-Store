using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookieDB.Entity
{
    public class CartItem : EntityBase
    {
        public virtual Book BookItem { get; set; }

        public CartItem()
        {

        }

        public CartItem(Book book_)
        {
            this.BookItem = book_;
        }


    }
}
