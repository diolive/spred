using System.Collections.Generic;

using Microsoft.AspNetCore.Identity;

namespace DioLive.Spred.WebUI.Models.ManageViewModels
{
    public class IndexViewModel
    {
        public string Name { get; set; }

        public bool HasPassword { get; set; }

        public IList<UserLoginInfo> Logins { get; set; }

        public string PhoneNumber { get; set; }

        public bool TwoFactor { get; set; }

        public bool BrowserRemembered { get; set; }
    }
}