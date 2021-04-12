using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Post
{
    public class DetailsModel : PageModel
    {
        private readonly MyMeals.Models.MijnMaaltijdContext _context;

        public DetailsModel(MyMeals.Models.MijnMaaltijdContext context)
        {
            _context = context;
        }

        public Models.Post Post { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Post = await _context.Posts
                .Include(p => p.Gebruiker)
                .Include(p => p.Maaltijd).FirstOrDefaultAsync(m => m.PostId == id);

            if (Post == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
