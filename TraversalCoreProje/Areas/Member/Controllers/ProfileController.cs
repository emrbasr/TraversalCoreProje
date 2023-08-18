using Entity.Concrete;

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.IO;
using System.Threading.Tasks;
using TraversalCoreProje.Areas.Member.Models;

namespace TraversalCoreProje.Areas.Member.Controllers
{

    [Area("Member")]
    [Route("Member/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<AppUser> _userManager;

        public ProfileController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values= await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel userEditViewModel = new UserEditViewModel();
            userEditViewModel.surname = values.SurName;
            userEditViewModel.name = values.Name;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.email = values.Email;

            return View(userEditViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel userEditViewModel)
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            if (userEditViewModel.image!=null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(userEditViewModel.image.FileName);
                var imagenmae= Guid.NewGuid()+extension;
                var savelocation = resource + "/wwwroot/UserImage/" + imagenmae;
                var stream = new FileStream(savelocation, FileMode.Create);
                await userEditViewModel.image.CopyToAsync(stream);
                
            }
            userEditViewModel.surname = values.SurName;
            userEditViewModel.name = values.Name;
            userEditViewModel.phonenumber = values.PhoneNumber;
            userEditViewModel.email = values.Email;

            return View(userEditViewModel);
        }
    }
}
