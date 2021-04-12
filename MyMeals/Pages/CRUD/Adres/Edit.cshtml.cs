﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyMeals.Models;

namespace MyMeals.Pages.Adres
{
    public class EditModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public EditModel(MyMeals.Data.MijnMaaltijdContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Adres).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AdresExists(Adres.AdresId))
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

        private bool AdresExists(int id)
        {
            return _context.Adres.Any(e => e.AdresId == id);
        }
    }
}
