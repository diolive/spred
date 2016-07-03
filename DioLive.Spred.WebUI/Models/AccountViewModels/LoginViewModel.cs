using System.ComponentModel.DataAnnotations;

namespace DioLive.Spred.WebUI.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me?")]
        public bool RememberMe { get; set; }
    }
}