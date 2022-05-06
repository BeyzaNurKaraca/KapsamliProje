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
    public class CountiesRepos : BaseRepository<Counties>, ICountiesRepos
    {
        public CountiesRepos(Context db) : base(db)
        {

        }
        public List<CountisList> GetCountiesLists()
        {
            return Set().Select(x => new CountisList
            {
                Id = x.Id,
                CountyName = x.CountyName
            }).ToList();
        }
    }
}
