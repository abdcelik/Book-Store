using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fusion.Entity
{
    public class Order : EntityBase
    {
        public virtual User User { get; set; }

        public virtual Book Book { get; set; }
    }
}