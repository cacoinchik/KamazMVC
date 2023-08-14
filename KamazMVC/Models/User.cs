using Microsoft.AspNetCore.Identity;

namespace KamazMVC.Models
{
    public class User : IdentityUser
    {
        public string? Surname { get; set; }
        public string? Name { get; set; }
        public string? Patronymic { get; set; }
    }
}
