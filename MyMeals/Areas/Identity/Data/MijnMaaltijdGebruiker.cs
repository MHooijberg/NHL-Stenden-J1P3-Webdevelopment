using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyMeals.Areas.Identity.Data
{
    public class MijnMaaltijdGebruiker : IdentityUser
    {
        [PersonalData]
        public string Voornaam { get; set; }
        [PersonalData]
        public string Achternaam { get; set; }
        [PersonalData]
        public string Profielnaam { get; set; }
        //public int AdresId { get; set; /

    }
}
