using Microsoft.EntityFrameworkCore;
using Super_Market_web.Data;

namespace SuperMarketWEB
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddRazorPages();

            builder.Services.AddDbContext<SuperMarketContext>(options =>
                options.UseSqlServer(builder.Configuration.GetConnectionString("SupermarketDB"))
            );

            var app = builder.Build();

            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseRouting();
            app.UseAuthorization();

            app.MapRazorPages();

            app.Run();
        }
    }
}