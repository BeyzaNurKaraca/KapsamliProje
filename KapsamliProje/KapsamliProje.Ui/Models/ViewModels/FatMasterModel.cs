using KapsamliProje.Dto;
using KapsamliProje.Ent;

namespace KapsamliProje.Ui.Models.ViewModels
{
    public class FatMasterModel
    {
     //   public  FatMaster ?FatMaster { get; set; }
        public List<EmployeesSelect> ?Employees { get; set; }
        public List<CustomersSelect>? Customers{ get; set; }
        public int EmployeeId{ get; set; }
        public int CustomerId { get; set; }
        public DateTime Date   { get; set; }
    }
}
