using Microsoft.AspNetCore.Mvc;

namespace KamazMVC.Controllers
{
    public class DocumentController : Controller
    {
        public IActionResult Index() => View();
    }
}
