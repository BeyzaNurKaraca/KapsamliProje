using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Customer:Enterprize
    {
        public Customer()
        {
            FatMaster = new HashSet<FatMaster>();   
        }
        public ICollection<FatMaster> ?FatMaster { get; set; }
    }
}
