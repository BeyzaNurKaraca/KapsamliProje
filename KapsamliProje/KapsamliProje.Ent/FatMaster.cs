using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Ent
{
    public class FatMaster:Base
    {
        public FatMaster()
        {
            FatDetails = new  HashSet<FatDetail>();
        }
        public DateTime Date { get; set; }
        public int CustomerId { get; set; }
        public int EmployeeId { get; set; }
        public ICollection<FatDetail>  ?FatDetails { get; set; }
        [ForeignKey("CustomerId")]
        public Customer ?Customer { get; set; }

        [ForeignKey("EmployeeId")]
        public Employees Employees { get; set; }
    }
}
