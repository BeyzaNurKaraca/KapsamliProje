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
   public class ProductRepos : BaseRepository<Products>, IProductsRepos

    {
        public ProductRepos(Context db) : base(db)
        {
        }

        public List<ProductsList> GetProductsLists()
        {
            return Set().Select(x => new ProductsList
            {
                Id = x.Id,
                ProductName = x.ProductName,
                CategoryName = x.Categories.CategoryName,
                CompanyName =x.Suppliers.CompanyName,
                EmployesName =x.Employees.Name,
                EmployesSurname =x.Employees.Surname,


            }).ToList();
        }
        public List<ProductsSelect> GetProductsSelect()
        {
            return Set().Select(x => new ProductsSelect
            {
                Id = x.Id,
                ProductName = x.ProductName,
            }).ToList();
        }
    }
}
