using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
abstract    public class Enterprize:Base
    {
        public string  ?CompanyName { get; set; }
        public string   ?ContactName{ get; set; }
        public int CountyId{ get; set; }
        public string ?Phone { get; set; }
        public string  ?TaxNumber { get; set; }

    }
}
