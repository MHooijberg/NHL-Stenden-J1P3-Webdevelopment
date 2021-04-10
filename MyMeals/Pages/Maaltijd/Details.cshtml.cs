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
    public class DetailsModel : PageModel
    {
        private readonly MyMeals.Models.MijnMaaltijdContext _context;

        public DetailsModel(MyMeals.Models.MijnMaaltijdContext context)
        {
            _context = context;
        }

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
    }
}
