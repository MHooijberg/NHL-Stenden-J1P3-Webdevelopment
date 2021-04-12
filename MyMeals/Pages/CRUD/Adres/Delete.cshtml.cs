using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Adres
{
    public class DeleteModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public DeleteModel(MyMeals.Data.MijnMaaltijdContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Adres Adres { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Adres = await _context.Adres.FirstOrDefaultAsync(m => m.AdresId == id);

            if (Adres == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Adres = await _context.Adres.FindAsync(id);

            if (Adres != null)
            {
                _context.Adres.Remove(Adres);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
