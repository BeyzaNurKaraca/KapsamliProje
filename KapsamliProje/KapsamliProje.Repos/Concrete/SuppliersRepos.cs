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
    public class SuppliersRepos : BaseRepository<Suppliers>, ISuppliersRepos
    {
        public SuppliersRepos(Context db) : base(db)
        {
        }

        public List<SuppliersList> GetSuppliersLists()
        {
            return Set().Select(x => new SuppliersList
            {
                Id = x.Id,
                CountyId = x.CountyId,
                ContactName = x.ContactName,
                CompanyName = x.CompanyName,
                TaxNumber = x.TaxNumber,
                Phone = x.Phone,

            }).ToList();
        }
    }
}
