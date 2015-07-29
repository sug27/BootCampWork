using System;
using System.Globalization;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using SportStore.WebUI.Infrastructure.Abstract;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using SportStore.WebUI.Models;

namespace SportStore.WebUI.Controllers
{
    
    public class AccountController : Controller
    {
        IAuthProvider authProvider;

        public AccountController(IAuthProvider auth)
        {
            authProvider = auth;
        }

        public ViewResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(LoginViewModel model, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if(authProvider.Authenticate(model.UserName, model.Password))
                {
                    //return Redirect(Url.Action("Index", "Home"));
                    return Redirect(returnUrl ?? Url.Action("Index", "Admin"));
                }else
                {
                    ModelState.AddModelError("", "Incorrect username or password");
                    return View();
                }
            }else
            {
                return View();
            }
        }
    }  
}