using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Id { get; set; }

        public string UserName { get; set; }

        [Display(Name = "Старый пароль")]
        [DataType(DataType.Password)]
        public string OldPassword { get; set; }

        [Display(Name = "Новый пароль")]
        [DataType(DataType.Password)]
        public string NewPassword { get; set; }

        [Display(Name = "Повторите новый пароль")]
        [Compare("NewPassword", ErrorMessage = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    }
}
