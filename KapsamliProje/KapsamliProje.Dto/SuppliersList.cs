using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Dto
{
    public class SuppliersList
    {
        public int Id { get; set; }
        public string ?CompanyName { get; set; }
        public string ?ContactName { get; set; }
        public int CountyId { get; set; }
        public string ?Phone { get; set; }
        public string ?TaxNumber { get; set; }
    }
}
