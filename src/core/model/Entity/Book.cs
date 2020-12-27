using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FusionBookieDB.Entity
{
    public class Book : EntityBase
    {
        public string Name { get; set; }

        public double Price { get; set; }

        public string Author { get; set; }

        public string Edition { get; set; }

        public int Page { get; set; }

        public string PhotoUrl { get; set; }

        public virtual string Category_1 { get; set; }

        public virtual string Category_2 { get; set; }

        public virtual string Category_3 { get; set; }

        public int FilterID { get; set; }

        public virtual User User { get; set; }

        public Book()
        {
            
        }

        

        public List<string> GetBookInfo()
        {
            //TODO

            return null;
        }

        //TODO Book const
    }
}
