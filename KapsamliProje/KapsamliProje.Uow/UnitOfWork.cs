using KapsamliProje.Dal;
using KapsamliProje.Repos.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsamliProje.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        Context _db;
        public ICategoriesRepos _categoriesRepos { get;private set; }

        public IProductsRepos _productsRepos { get; private set; }

        public ISuppliersRepos _suppliersRepos { get; private set; }

        public ICitiesRepos _citiesRepos { get; private set; }

        public ICustomersRepos _customersRepos { get; private set; }

        public ICountiesRepos _countiesRepos { get; private set; }

        public IEndConsumersRepos _endConsumersRepos { get; private set; }

        public IEmployeesRepos _employeesRepos { get; private set; }
        public IAuthRepos _authRepos { get; private set; }

        public IFatMasterRepos _fatmasterRepos { get; private set; }

        public IFatDetailRepos _fatdetailRepos { get; private set; }    

        public UnitOfWork(Context db,ICategoriesRepos categoriesRepos,IProductsRepos productsRepos, ISuppliersRepos suppliersRepos, IEmployeesRepos employeesRepos, ICountiesRepos countiesRepos, ICustomersRepos customersRepos , IEndConsumersRepos endConsumersRepos, ICitiesRepos citiesRepos,IAuthRepos authRepos,IFatMasterRepos fatMasterRepos,IFatDetailRepos fatDetailRepos)
        {
            _db = db;
            _categoriesRepos = categoriesRepos;
            _productsRepos = productsRepos;
            _suppliersRepos = suppliersRepos;
            _employeesRepos = employeesRepos;
            _citiesRepos = citiesRepos;
            _countiesRepos = countiesRepos;
            _customersRepos = customersRepos;
            _endConsumersRepos = endConsumersRepos;
            _authRepos = authRepos;
            _fatdetailRepos = fatDetailRepos;
            _fatmasterRepos = fatMasterRepos;
        }
        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
