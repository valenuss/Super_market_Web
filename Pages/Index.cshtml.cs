<<<<<<< HEAD
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Super_Market_web.Pages
=======
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SuperMarketWEB.Pages
>>>>>>> d0a7c64 (Se ajusta el NuGet)
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {

        }
    }
}
