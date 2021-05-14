using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MuckScraperMVCApp.Models;
using MuckScraperMVCApp.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MuckScraperMVCApp.Controllers
{
    public class AccountController : Controller
    {
        private UserManager<User> UserMgr { get; }

        private SignInManager<User> SignInMgr { get; }

        public AccountController(UserManager<User> userManager,
            SignInManager<User> signInManager)
        {
            UserMgr = userManager;
            SignInMgr = signInManager;

        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterModel userModel)
        {
            if (ModelState.IsValid)
            {

                var user = new User()
                {
                    FirstName = userModel.FirstName,
                    LastName = userModel.LastName,
                    PhoneNumber = userModel.ContactNumber,
                    UserName = userModel.Email,
                    Email = userModel.Email,
                    
                };
                var result = await UserMgr.CreateAsync(user, userModel.Password);

                if (result.Succeeded)
                {

                    await SignInMgr.SignOutAsync();
                    if ((await SignInMgr.PasswordSignInAsync(user.UserName, userModel.Password, false, false))
                        .Succeeded)
                    {
                        return RedirectToAction("Index", "Home");
                    }
                }
                else
                {
                    return View();
                }

            }

            return View();
        }
        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginModel login)
        {

            var result = await SignInMgr.PasswordSignInAsync(login.UserName, login.Password, false, false);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Result = "result is" + result.ToString();
            }
            return View();
        }

        public async Task<IActionResult> Logout()
        {
            await SignInMgr.SignOutAsync();
            return RedirectToAction("Login", "Account");
        }
    }
}
