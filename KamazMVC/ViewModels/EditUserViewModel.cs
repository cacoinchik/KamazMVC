using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Display(Name = "Ваша фамилия")]
        public string? Surname { get; set; }

        [Display(Name = "Ваше имя")]
        public string? Name { get; set; }

        [Display(Name = "Ваше отчество")]
        public string? Patronymic { get; set; }

        [Display(Name = "Ваша почта")]
        [DataType(DataType.EmailAddress)]
        public string? Email { get; set; }
    }
}
