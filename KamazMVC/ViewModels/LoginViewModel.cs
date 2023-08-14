using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Введите ваш логин")]
        [Display(Name = "Логин")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "Введите ваш пароль")]
        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Запомнить меня?")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
