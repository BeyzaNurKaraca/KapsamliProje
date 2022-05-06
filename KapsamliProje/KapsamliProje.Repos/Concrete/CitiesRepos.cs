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
    public class CitiesRepos:BaseRepository<Cities>,ICitiesRepos
    {
        public CitiesRepos(Context db):base(db)
        {

        }

        
        List<CitiesList> ICitiesRepos.GetCitiesLists()
        {
            return Set().Select(x => new CitiesList
            {
                Id = x.Id,
                CityName = x.CityName,

            }).ToList();
        }
    }
}
