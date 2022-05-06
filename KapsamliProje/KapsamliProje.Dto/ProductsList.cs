using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Dto
{
    public class ProductsList
    {
        public int Id { get; set; }
        public string ?ProductName { get; set; }
        public string ?CompanyName { get; set; }
        public string ?CategoryName { get; set; }
        public string ?EmployesName { get; set; }
        public string ?EmployesSurname { get; set; }
        public decimal UnitPrice { get; set; }
        public int Stock { get; set; }
    }
}
