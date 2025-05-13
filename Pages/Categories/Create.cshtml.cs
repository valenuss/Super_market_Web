using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApp.Data; // Cambia seg�n tu namespace
using WebApp.Models; // Cambia seg�n tu namespace

public class CreateModel : PageModel
{
    private readonly AppDbContext _context;

    public CreateModel(AppDbContext context)
    {
        _context = context;
    }

    [BindProperty]
    public Categoria Categoria { get; set; }

    public IActionResult OnGet()
    {
        return Page();
    }

    public async Task<IActionResult> OnPostAsync()
    {
        if (!ModelState.IsValid)
        {
            return Page();
        }

        _context.Categorias.Add(Categoria);
        await _context.SaveChangesAsync();

        return RedirectToPage("Index");
    }
}
