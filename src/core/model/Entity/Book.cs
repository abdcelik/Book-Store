using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion.Entity
{
    public class Book : EntityBase
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Author { get; set; }

        public string Edition { get; set; }

        public int Page { get; set; }

        public Photo Photo { get; set; }

        public List<Tag> Tags { get; set; }

        public virtual User User { get; set; }

        public Book()
        {

        }
    }
}
