using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class EditUserViewModel
    {
        public string Id { get; set; }

        [Required]
        [Display(Name = "Ваша фамилия")]
        public string? Surname { get; set; }

        [Required]
        [Display(Name = "Ваше имя")]
        public string? Name { get; set; }

        [Required]
        [Display(Name = "Ваше отчество")]
        public string? Patronymic { get; set; }
    }
}
