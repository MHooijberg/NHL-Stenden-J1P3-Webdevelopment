using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Gebruiker
{
    public class EditModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public EditModel(MyMeals.Data.MijnMaaltijdContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Models.Gebruiker Gebruiker { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Gebruiker = await _context.Gebruikers
                .Include(g => g.Adres).FirstOrDefaultAsync(m => m.GebruikerId == id);

            if (Gebruiker == null)
            {
                return NotFound();
            }
           ViewData["AdresId"] = new SelectList(_context.Adres, "AdresId", "Huisnummer");
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

            _context.Attach(Gebruiker).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GebruikerExists(Gebruiker.GebruikerId))
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

        private bool GebruikerExists(int id)
        {
            return _context.Gebruikers.Any(e => e.GebruikerId == id);
        }
    }
}
