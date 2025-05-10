<<<<<<< HEAD
﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Super_Market_web.Pages
=======
﻿using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperMarketWEB.Pages
>>>>>>> d0a7c64 (Se ajusta el NuGet)
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;

        public PrivacyModel(ILogger<PrivacyModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }

}
