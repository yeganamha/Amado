using Amado.Areas.Admin.Models;
using Amado.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Amado.General;

namespace Amado.Areas.Admin.Controllers
{
   
    public class AccountController : Basecontroller
    {
        private readonly SignInManager<AppUser> _signInManager;
        private readonly UserManager<AppUser> _userManager;
        public AccountController(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager)
        {
           _signInManager = signInManager;
            _userManager = userManager;
        }
            
        public IActionResult SignIn()
        {
            return View();
        }

        //[HttpPost]
        //public async Task<IActionResult>  SignIn(AccountSignInVM model)
        //{
        //    var user = await _userManager.FindByNameAsync(model.UserName);
        //    if (user == null) return View(model);
        //    await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
        //    return RedirectToAction(Constants.AdminRoutes.HomeIndexAction, Constants.AdminRoutes.HomeController);
        //    //return RedirectToAction("Index", "Home");
        //}

        [HttpPost]
        public async Task<IActionResult> SingIn(AccountSignInVM model)
        {
            var user = await _userManager.FindByNameAsync(model.UserName);

            if (user is null) return View(model);
            var result = await _signInManager.PasswordSignInAsync(user, model.Password, false, false);
            //if (!result.Succeeded)
            //{
            //    model.ErrorMessage = "Email or password is wrong";
            //    return View(model);
            //}
            return RedirectToAction(Constants.AdminRoutes.HomeIndexAction, Constants.AdminRoutes.HomeController);
            return RedirectToAction("Index", "Home");

        }

    }
}
