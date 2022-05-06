using KapsamliProje.Ent;
using KapsamliProje.Ui.Models.ViewModels;
using KapsamliProje.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KapsamliProje.Ui.Controllers
{
    public class FatDetailController : Controller
    {
        IUnitOfWork _unitOfWork;
        FatDetailModel _model;
        FatDetail _fatDetail;
        public FatDetailController(IUnitOfWork unitOfWork, FatDetailModel model, FatDetail fatDetail)
        {
            _unitOfWork = unitOfWork;
            _model = model;
            _fatDetail = fatDetail; 
        }
        public IActionResult Create(int id)
        {
             
            var fm = _unitOfWork._fatmasterRepos.Find(id);
            var cus = _unitOfWork._customersRepos.Find(fm.CustomerId);
            var emp = _unitOfWork._employeesRepos.Find(fm.EmployeeId);
            _model.Customers = cus;
            _model.Employees = emp;
            _model.FatMaster = fm;
            _model.Products = _unitOfWork._productsRepos.GetProductsSelect();
            _model.FatDetailList = _unitOfWork._fatdetailRepos.GetDetailList(id);
            _model.Product = _unitOfWork._productsRepos.Find(_model.ProductId);
             
            return View(_model);
        }
        [HttpPost] 
        public IActionResult Create(int id ,FatDetailModel model)
        {
            var a = model.ProductId;
            Products product = _unitOfWork._productsRepos.Find(model.ProductId);
          //  model.UnitPrice = product.UnitPrice;
         //   model.Total = product.UnitPrice * model.Amount;
            _fatDetail.UnitPrice=product.UnitPrice;
            _fatDetail.Amount = model.Amount;
            _fatDetail.ProductId = model.ProductId;
            _fatDetail.Products = _unitOfWork._productsRepos.Find(model.ProductId);
            _fatDetail.Id = id;
            _unitOfWork._fatdetailRepos.Create(_fatDetail);
            
            _unitOfWork.Save();
            var fm = _unitOfWork._fatmasterRepos.Find(id);
            model.FatMaster = _unitOfWork._fatmasterRepos.Find(id);
            model.Products = _unitOfWork._productsRepos.GetProductsSelect();
            model.Product = _unitOfWork._productsRepos.Find(model.ProductId);
            model.FatDetailList = _unitOfWork._fatdetailRepos.GetDetailList(id);
            model.Customers = _unitOfWork._customersRepos.Find(fm.CustomerId);
            model.Employees = _unitOfWork._employeesRepos.Find(fm.EmployeeId);
            return View(model);
        }
        public IActionResult Update(int id , int productId )
        {
            FatDetail fd = _unitOfWork._fatdetailRepos.Find(id,productId);
            return View(fd);
        }
        [HttpPost]
        public IActionResult Update(int id ,FatDetail model)
        {
            _unitOfWork._fatdetailRepos.Find(id, model.ProductId);
            _unitOfWork._fatdetailRepos.Update(model);
            _unitOfWork.Save();
            return RedirectToAction("Create");
        }
    }
}
