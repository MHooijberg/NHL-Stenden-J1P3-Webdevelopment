using System;
using System.Collections.Generic;

#nullable disable

namespace MyMeals.Models
{
    public partial class Gebruiker
    {
        public Gebruiker()
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
