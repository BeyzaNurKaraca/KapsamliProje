using KapsamliProje.Dto;
using KapsamliProje.Ent;

namespace KapsamliProje.Ui.Models.ViewModels
{
    public class FatDetailModel
    {
        public Customer? Customers { get; set; }
        public FatMaster? FatMaster { get; set; }
        public Employees? Employees { get; set; }
        public int ProductId { get; set; }
        public List<ProductsSelect>? Products { get; set; }
        public Products  ?Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Amount { get; set; }
        public decimal Total { get; set; }
        public IQueryable<FatDetailList> ?FatDetailList{ get; set; }
    }
}
