using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace DioLive.Spred.WebUI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public virtual byte[] Photo { get; set; }

        public virtual byte[] Avatar { get; set; }
    }
}