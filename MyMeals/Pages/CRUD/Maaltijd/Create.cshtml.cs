using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyMeals.Models;

namespace MyMeals.Pages.Maaltijd
{
    public class CreateModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public CreateModel(MyMeals.Data.MijnMaaltijdContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
        ViewData["GebruikerId"] = new SelectList(_context.Gebruikers, "GebruikerId", "AchterNaam");
            return Page();
        }

        [BindProperty]
        public Models.Maaltijd Maaltijd { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Maaltijds.Add(Maaltijd);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
