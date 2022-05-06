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
    public class FatMasterRepos:BaseRepository<FatMaster>, IFatMasterRepos
    {
        public FatMasterRepos(Context db):base(db)
        {

        }

        public List<FatList> GetFatLists()
        {
           return  Set().Select(x=> new FatList
            {
                 Id= x.Id,
                 CompanyName = x.Customer.CompanyName,
                 Date = x.Date
            }).ToList();
        }
    }
}
