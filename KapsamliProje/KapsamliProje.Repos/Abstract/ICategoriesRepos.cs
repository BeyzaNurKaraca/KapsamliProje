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
    public interface ICategoriesRepos : IBaseRepository<Categories>
    {
        List<CategoriesList> GetCategoriesLists();
    }
}
