using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Employees:Human
    {
        public Employees()
        {
            Products = new HashSet<Products>();
            FatMaster = new HashSet<FatMaster>();
        }
         
        public ICollection<Products> Products { get; set; }
        public ICollection<FatMaster> FatMaster { get; set; }
    }
}
