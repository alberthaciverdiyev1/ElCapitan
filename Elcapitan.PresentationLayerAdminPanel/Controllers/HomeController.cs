using Microsoft.AspNetCore.Mvc;

namespace Elcapitan.PresentationLayerAdminPanel.Controllers;

public class HomeController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}