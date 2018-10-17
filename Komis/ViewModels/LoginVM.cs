using System.ComponentModel.DataAnnotations;

namespace Komis.ViewModels
{
    public class LoginVM
    {
        [Required]
        [Display(Name = "Nazwa Użytkownika")]
        public string UserName { get; set; }
        [Required]
        [Display(Name = "Hasło")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
