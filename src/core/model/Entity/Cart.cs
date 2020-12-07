using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookStore.Entity
{
    public class Cart : EntityBase
    {
        public virtual List<Book> Books { get; set; }

        public double Price { get; set; }


    }
}
