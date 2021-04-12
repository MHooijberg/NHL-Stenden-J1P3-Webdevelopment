using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Maaltijd
{
    public class EditModel : PageModel
    {
        private readonly MyMeals.Models.MijnMaaltijdContext _context;

        public EditModel(MyMeals.Models.MijnMaaltijdContext context)
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
           ViewData["GebruikerId"] = new SelectList(_context.Gebruikers, "GebruikerId", "AchterNaam");
            return Page();
        }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Maaltijd).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MaaltijdExists(Maaltijd.MaaltijdId))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool MaaltijdExists(int id)
        {
            return _context.Maaltijds.Any(e => e.MaaltijdId == id);
        }
    }
}
