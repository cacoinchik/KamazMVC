using KamazMVC.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace KamazMVC.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly AppDbContext _db;
        public ProfileController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            if(User.Identity.IsAuthenticated)
            {
                return View(await _db.Users.FirstOrDefaultAsync(user=>user.UserName==User.Identity.Name));
            }
            return BadRequest("Пользователь не найден, обратитесь в техническую поддержку");
        }
    }
}
