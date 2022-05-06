using KapsamliProje.Uow;
using Microsoft.AspNetCore.Mvc;


namespace KapsamliProje.Ui.Controllers
{
    public class ProductsController : Controller
    {
        IUnitOfWork _uw;
        public ProductsController(IUnitOfWork unitOfWork)
        {
            _uw = unitOfWork;
        }
        public IActionResult List()
        {
           
            
            return View(_uw._productsRepos.GetProductsLists());
        }
    }
}
