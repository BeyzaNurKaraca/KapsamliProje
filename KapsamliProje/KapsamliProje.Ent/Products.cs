using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class Products:Base
    {
        
        public string  ProductName  { get; set; }
        public int CategoryId { get; set; }
        public int SupplierId { get; set; }
        public int EmployeeId { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
        public bool Status { get; set; }
        [ForeignKey("CategoryId")]
        public Categories Categories { get; set; }
        [ForeignKey("SupplierId")]
        public Suppliers Suppliers { get; set; }
        [ForeignKey("EmployeeId")]
        public Employees Employees { get; set; }
    }
}
