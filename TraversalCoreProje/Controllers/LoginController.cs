﻿
using Entity.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TraversalCoreProje.Models;

namespace TraversalCoreProje.Controllers
{
    [AllowAnonymous]  //Altına yazılan bütün kodları geçerli bütün kurallardan muaf tutar
    public class LoginController : Controller
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly SignInManager<AppUser> _signInManager;

        public LoginController(UserManager<AppUser> userManager, SignInManager<AppUser> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }

        [HttpGet]
        public IActionResult SignUp()
        {
            return View();
        }

		[HttpPost]
		public async Task<IActionResult> SignUp(UserRegisterViewModel p)
		{
            AppUser appUser = new AppUser()
            {
                Name = p.Name,
                SurName = p.SurName,
                Email=p.Mail,
                UserName = p.UserName

            };
            if (p.Password==p.ConfirmPassword)
            {
                var result = await _userManager.CreateAsync(appUser, p.Password);
                if (result.Succeeded)
                {
                    return RedirectToAction("SignIn");
                }
                else
                {
                    foreach (var item in result.Errors)
                    {
                        ModelState.AddModelError("", item.Description);
                    }
                }
            }
			return View(p);
		}

		[HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSingInViewModel p)
        {
            if (ModelState.IsValid)
            {
                var result = await _signInManager.PasswordSignInAsync(p.username,p.password,false,true);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile", new {area="Member"});
                }
                else
                {
                    return RedirectToAction("SignIn", "Login");
                }
            }
            return View();
        }
    }
}
