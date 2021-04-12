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
    public class IndexModel : PageModel
    {
        private readonly MyMeals.Data.MijnMaaltijdContext _context;

        public IndexModel(MyMeals.Data.MijnMaaltijdContext context)
        {
            _context = context;
        }

        public IList<Models.Adres> Adres { get;set; }

        public async Task OnGetAsync()
        {
            Adres = await _context.Adres.ToListAsync();
        }
    }
}
