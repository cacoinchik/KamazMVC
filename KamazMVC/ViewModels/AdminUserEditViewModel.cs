using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class AdminUserEditViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Логин пользователя")]
        public string UserName { get; set; }

        [Required]
        [Display(Name = "Фамилия пользователя")]
        public string? Surname { get; set; }

        [Required]
        [Display(Name = "Имя пользователя")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Отчество пользователя")]
        public string? Patronymic { get; set; }

    }
}
