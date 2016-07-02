using System.ComponentModel.DataAnnotations;

namespace DioLive.Spred.WebUI.Models.AccountViewModels
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
    }
}