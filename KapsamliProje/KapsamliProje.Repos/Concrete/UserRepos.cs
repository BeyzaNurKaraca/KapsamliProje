using KapsamliProje.Core;
using KapsamliProje.Dal;
using KapsamliProje.Ent;
using KapsamliProje.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Repos.Concrete
{
    public class UserRepos:BaseRepository<Users>, IUserRepos
    {
        public UserRepos(Context db):base(db)
        {
             
        }
    }
}
