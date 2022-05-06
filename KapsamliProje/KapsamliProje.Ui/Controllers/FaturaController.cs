using KapsamliProje.Ent;
using KapsamliProje.Ui.Models;
using KapsamliProje.Ui.Models.ViewModels;
using KapsamliProje.Uow;
using Microsoft.AspNetCore.Mvc;

namespace KapsamliProje.Ui.Controllers
{
    public class FaturaController : Controller
    {
        IUnitOfWork _unitOfWork;
        FatMaster _fatMaster;
        FatMasterModel _fmModel;
        public FaturaController(IUnitOfWork unitOfWork, FatMaster fatMaster, FatMasterModel fmModel)
        {
            _unitOfWork = unitOfWork;
            _fatMaster = fatMaster;
            _fmModel = fmModel;
        }
        public IActionResult List()
        {
            return View(_unitOfWork._fatmasterRepos.GetFatLists());
        }
        public IActionResult Create()
        {
            _fmModel.Employees = _unitOfWork._employeesRepos.GetEmployeesSelects();
            _fmModel.Customers = _unitOfWork._customersRepos.GetCustomersSelect();
            return View(_fmModel);
        }
        [HttpPost]
        public IActionResult Create(FatMasterModel model)
        {
            
            _fatMaster.CustomerId = model.CustomerId;   
            _fatMaster.EmployeeId = model.EmployeeId;
            _unitOfWork._fatmasterRepos.Create(_fatMaster);
            _unitOfWork.Save();
            return  RedirectToAction("Create", "FatDetail" , new { id =    _fatMaster.Id });
        }
    }
}
