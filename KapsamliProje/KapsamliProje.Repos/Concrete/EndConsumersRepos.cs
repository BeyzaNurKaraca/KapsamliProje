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
    public class EndConsumersRepos : BaseRepository<EndConsumers>, IEndConsumersRepos
    {
        public EndConsumersRepos(Context db) : base(db)
        {
        }

        public List<EndConsumersList> GetEndConsumersLists()
        {
            return Set().Select(x => new EndConsumersList
            {
                Id = x.Id,
               CountyId = x.CountyId,
                Name = x.Name,
                Surname = x.Surname,

            }).ToList();
        }
    }
}
