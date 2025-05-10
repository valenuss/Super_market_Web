<<<<<<< HEAD
using Microsoft.EntityFrameworkCore;
using Super_Market_web.Data;

namespace Super_Market_web
=======
namespace SuperMarketWEB
>>>>>>> d0a7c64 (Se ajusta el NuGet)
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();

            //Agregando el contexto SupermarketContext a la aplicaci�n
            builder.Services.AddDbContext<SuperMarketContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("SupermarketDB"))
            );
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
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
