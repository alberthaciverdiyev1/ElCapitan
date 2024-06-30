using ElCapitan.DtoLayer.AppUserDtos;
using ElCapitan.EntityLayer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Elcapitan.PresentationLayerAdminPanel.Controllers
{
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
        public IActionResult Index()
        {
            return View("../Auth/Login");
        }

        [HttpPost]
        public async Task<IActionResult> Login(AppUserLoginDto appUserLoginDto)
        {
            var result = await _signInManager.PasswordSignInAsync(appUserLoginDto.Username, appUserLoginDto.Password,false,false);
            if (result.Succeeded) { 
                var user = await _userManager.FindByNameAsync(appUserLoginDto.Username);
                if (user.EmailConfirmed == true)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            return View();
        }
    }
}
