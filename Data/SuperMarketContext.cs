using Microsoft.EntityFrameworkCore;
using Super_Market_web.Models;
using SupermarketWEB.Models;


namespace Super_Market_web.Data
{
    public class SuperMarketContext
    {
        public SuperMarketContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Product> Products { get; set; }

        public DbSet<Category> categories { get; set; } 
    }
}
