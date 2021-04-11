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
    public class DetailsModel : PageModel
    {
        private readonly MyMeals.Models.MijnMaaltijdContext _context;

        public DetailsModel(MyMeals.Models.MijnMaaltijdContext context)
        {
            _context = context;
        }

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
    }
}
