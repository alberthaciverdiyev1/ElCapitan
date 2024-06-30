using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Elcapitan.PresentationLayerAdminPanel.Controllers;

public class HomeController : Controller
{
    // GET
    [Authorize]
    public IActionResult Index()
    {
        //if (!User.Identity.IsAuthenticated)
        //{
        //    return RedirectToAction("Login", "Account");
        //}
        return View();
    }
}