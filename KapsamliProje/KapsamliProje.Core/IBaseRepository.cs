using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Core
{
 public interface IBaseRepository<T> where T : class
    {
        bool Create(T ent);
        bool Update(T ent);
        bool Delete(T ent);
        T Find(int id);
        T Find(int key1, int key2  );
        List<T> List();
        IQueryable<T> Query();
        DbSet<T> Set();
    }
}
