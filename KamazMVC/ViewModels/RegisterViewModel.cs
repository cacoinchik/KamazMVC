using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class RegisterViewModel
    {
        [Display(Name = "Ваша фамилия")]
        public string? Surname { get; set; }

        [Display(Name = "Ваше имя")]
        public string? Name { get; set; }

        [Display(Name = "Ваше отчество")]
        public string? Patronymic { get; set; }

        [Required(ErrorMessage = "Введите ваш логин")]
        [Display(Name = "Ваш логин")]
        public string UserName { get; set; }

        [Display(Name = "Ваша почта")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }

        [Display(Name = "Ваш номер телефона")]
        [DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }

        [Required(ErrorMessage = "Введите ваш пароль")]
        [Display(Name = "Ваш пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Пожалуйста повторите ваш пароль")]
        [Display(Name = "Повторите ваш пароль")]
        [Compare("Password", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
