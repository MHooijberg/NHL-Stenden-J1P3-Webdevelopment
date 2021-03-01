using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyMeals.Data;
using MyMeals.Models;
namespace MyMeals.Pages
{
    public class ContactModel : PageModel
    {
        private readonly ContactDbContext _context;

        public ContactModel(ContactDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ContactRequest ContactRequest { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.ContactRequests.Add(ContactRequest);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Contact");
        }

    }
}
