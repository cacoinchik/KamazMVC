using Dadata;
using Microsoft.AspNetCore.Mvc;

namespace KamazMVC.Controllers
{
    public class DadataController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(string name)
        {
            var token = "d8a2d987d42f3921d619ab2dbbcba4d6d086898c";

            var api = new SuggestClientAsync(token);
            var response = await api.SuggestName(name);
            
            if(response.suggestions.Any())
            {
                var fio = response.suggestions;
                return View("Result",fio);
            }
            return View();
            
        }
    }
}
