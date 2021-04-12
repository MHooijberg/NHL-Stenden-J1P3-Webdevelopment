using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Maaltijd
{
    public class DeleteModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public DeleteModel(MyMeals.Data.MijnMaaltijdContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Maaltijd Maaltijd { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Maaltijd = await _context.Maaltijds
                .Include(m => m.Gebruiker).FirstOrDefaultAsync(m => m.MaaltijdId == id);

            if (Maaltijd == null)
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

            Maaltijd = await _context.Maaltijds.FindAsync(id);

            if (Maaltijd != null)
            {
                _context.Maaltijds.Remove(Maaltijd);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
