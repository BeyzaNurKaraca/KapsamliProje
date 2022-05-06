using KapsamliProje.Core;
using KapsamliProje.Dal;
using KapsamliProje.Dto;
using KapsamliProje.Ent;
using KapsamliProje.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Repos.Concrete
{
    public class CustomersRepos : BaseRepository<Customer>, ICustomersRepos
    {
        public CustomersRepos(Context db) : base(db)
        {
        }

        public List<CustomersList> GetCustomerLists()
        {
            return Set().Select(x => new CustomersList
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
                ContactName = x.ContactName,
                CountyId = x.CountyId,  
                 Phone = x.Phone,
                 TaxNumber = x.TaxNumber,
            }).ToList();
        }
        public List<CustomersSelect> GetCustomersSelect()
        {
            return Set().Select(x => new CustomersSelect
            {
                Id = x.Id,
                CompanyName = x.CompanyName,
               
            }).ToList();
        }

      
    }
}
