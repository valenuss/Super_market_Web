using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Super_Market_web.Data;
using SupermarketWEB.Models;
using SuperMarketWEB.Data;
using SuperMarketWEB.Models;

namespace Super_Market_web.Pages

    public class IndexModel : PageModel
{
    private readonly SuperMarketContext _context;

    public IndexModel(SuperMarketContext context)
    {
        context = context;
    }

    public IList<Category> categories { get; set; } = default!;

    public async Task OnGetAsync()
    {
        if (_context.Categories != null)
        {
            categories = await _context.Categories.ToListAsync();
      }
    }   
  }
}
