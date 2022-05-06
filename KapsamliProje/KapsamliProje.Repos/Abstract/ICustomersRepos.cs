using KapsamliProje.Core;
using KapsamliProje.Dto;
using KapsamliProje.Ent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Repos.Abstract
{
    public interface ICustomersRepos : IBaseRepository<Customer>
    {
        List<CustomersList> GetCustomerLists();
        List<CustomersSelect> GetCustomersSelect(); 
    }
}
