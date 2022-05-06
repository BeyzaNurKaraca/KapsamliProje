using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Categories:Base
    {
        public Categories()
        {
            Products = new HashSet<Products>();
        }
        public string  ?CategoryName { get; set; }
        public ICollection<Products> Products { get; set; }
    }
}
