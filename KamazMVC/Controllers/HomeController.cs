using Microsoft.AspNetCore.Mvc;

namespace KamazMVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
