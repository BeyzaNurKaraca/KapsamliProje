
 
using KapsamliProje.Repos.Abstract;
using KapsamliProje.Ui.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using KapsamliProje.Ui.Extensions;
using KapsamliProje.Uow;
using KapsamliProje.Ent;

namespace KapsamliProje.Ui.Controllers
{
    public class AuthController : Controller
    {
        
        LoginModel _model;
        IUnitOfWork _unitOfWork;
        public const string Role = "Role";
        public const string UserName = "UserName";
        public AuthController(IUnitOfWork unitOfWork,  LoginModel model)
        {
            _unitOfWork = unitOfWork;  
            _model = model;

        }
        public IActionResult Register()
        {
            return View(_model);
        }
        [HttpPost]
        public IActionResult Register(LoginModel model)
        {
           _unitOfWork._authRepos.Register(model.UserId, model.Password);

            return  RedirectToAction("Index","Home");
        }
        public IActionResult Login( )
        {
            return View("Register",_model); 
        }
        [HttpPost]
        public IActionResult Login(LoginModel model)
        {
          Users user =   _unitOfWork. _authRepos.Login(model.UserId, model.Password);
            if (user != null)
            {
                HttpContext.Session.Set<string>(UserName, model.UserId);
                HttpContext.Session.Set<string>(Role, user.Role);
             var a =    HttpContext.Session.Get<string>(Role );
                return RedirectToAction("Index","Home");    
            }
            else
            {

                return RedirectToAction("Login" );
            }
           
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }

    }
}
