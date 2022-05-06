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
  public class FatDetailRepos:BaseRepository<FatDetail>, IFatDetailRepos
    {
        public FatDetailRepos(Context db):base(db)
        {

        }
        public IQueryable<FatDetailList> GetDetailList(int id)
        {
         
            return Set().Select(x => new FatDetailList
            {
                Id = x.Id,
                ProductId = x.ProductId,
                ProductName = x.Products.ProductName,
                Amount = x.Amount,
                UnitPrice = x.UnitPrice,
                Total = x.Amount * x.UnitPrice
            }).Where(x=> x.Id == id); 
             
        }
    }
}
