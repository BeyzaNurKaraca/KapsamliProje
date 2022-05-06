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
    public class EmployeesRepos : BaseRepository<Employees>, IEmployeesRepos
    {
        public EmployeesRepos(Context db) : base(db)
        {
        }

        public List<EmployeesList> GetEmployeesLists()
        {
            return Set().Select(x => new EmployeesList
            {
                Id = x.Id,
                 CountyId = x.CountyId, 
                Name = x.Name,
                Surname = x.Surname,

            }).ToList();
        }

        public List<EmployeesSelect> GetEmployeesSelects()
        {
            return Set().Select(x => new EmployeesSelect
            {
                FullName = x.Name + " " + x.Surname,
                Id = x.Id,
            }).ToList();
        }
    }
}
