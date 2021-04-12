using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using MyMeals.Models;

namespace MyMeals.Areas.Identity.Data
{
    // Add profile data for application users by adding properties to the MyMealsUser class
    public class MyMealsUser : IdentityUser
    {
        public MyMealsUser()
        {
            Maaltijds = new HashSet<Maaltijd>();
            Posts = new HashSet<Post>();
        }

        public int GebruikerId { get; set; }
        public string VoorNaam { get; set; }
        public string AchterNaam { get; set; }
        public string ProfielNaam { get; set; }
        public string Email { get; set; }
        public string Wachtwoord { get; set; }
        public int AdresId { get; set; }
        public string Telefoonnummer { get; set; }

        public virtual Adres Adres { get; set; }
        public virtual ICollection<Maaltijd> Maaltijds { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
