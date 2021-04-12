using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyMeals.Data;

namespace MyMeals.Pages.Adres
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
            return Page();
        }

        [BindProperty]
        public Models.Adres Adres { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Adres.Add(Adres);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
