﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Gebruiker
{
    public class DetailsModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public DetailsModel(MyMeals.Data.MijnMaaltijdContext context)
        {
            _context = context;
        }

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
            return Page();
        }
    }
}
