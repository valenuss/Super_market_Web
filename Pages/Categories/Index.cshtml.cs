using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Super_Market_web.Data;
using SupermarketWEB.Models;

namespace SupermarketWEB.Pages.Categories
{
    [Authorize]
    public class IndexModel : PageModel
    {
        private readonly SuperMarketContext _context;
        public IndexModel(SuperMarketContext context)
        {
            _context = context;
        }
        public IList<Category> Categories { get; set; }
        public async Task OnGetAsync()
        {
            //if (_context.Categories != null)
            //{
            Categories = await _context.Categories.ToListAsync();
            //}
        }

    }
}
