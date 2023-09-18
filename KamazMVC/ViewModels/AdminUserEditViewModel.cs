using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class AdminUserEditViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Логин пользователя")]
        public string UserName { get; set; }

        [Display(Name = "Фамилия пользователя")]
        public string? Surname { get; set; }

        [Display(Name = "Имя пользователя")]
        public string? Name { get; set; }

        [Display(Name = "Отчество пользователя")]
        public string? Patronymic { get; set; }

        [Display(Name = "Почта пользователя")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

    }
}
