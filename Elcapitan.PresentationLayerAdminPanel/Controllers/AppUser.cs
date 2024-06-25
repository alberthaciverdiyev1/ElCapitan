using Microsoft.AspNetCore.Mvc;

namespace Elcapitan.PresentationLayerAdminPanel.Controllers
{
    public class AppUser : Controller
    {
        public IActionResult LoginView()
        {
            return View("Login");
        }

        public IActionResult RegisterView() {
            return View("Register");
        }
    }
}
