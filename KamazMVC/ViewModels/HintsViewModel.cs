using System.ComponentModel.DataAnnotations;

namespace KamazMVC.ViewModels
{
    public class HintsViewModel
    {
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Name { get; set; }
    }
}
