using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookStore.Entity
{
    public class Book : EntityBase
    {
        public Book()
        {

        }


        public string Name { get; set; }

        public double Price { get; set; }

        public string Author { get; set; }

        public string Edition { get; set; }

        public int Page { get; set; }

        public string PhotoUrl { get; set; }

        public List<int> Tags { get; set; }

        public virtual User User { get; set; }
    }
}
