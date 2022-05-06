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
    public class CategoriesRepos : BaseRepository<Categories>, ICategoriesRepos
    {

        public CategoriesRepos(Context db) : base(db)
        {
            // Ek metod
        }

        public List<CategoriesList> GetCategoriesLists()

        {
            return Set().Select(x => new CategoriesList
            {
                Id = x.Id,
                CategoryName = x.CategoryName
                
            }).ToList();
        }

        
    }
}
