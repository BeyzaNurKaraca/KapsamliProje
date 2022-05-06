using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Dto
{
    public class FatDetailList
    {
        public int Id { get; set; }
        public int ProductId{ get; set; }
        public string  ?ProductName{ get; set; }
        public int Amount { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Total { get; set; }
    }
}
