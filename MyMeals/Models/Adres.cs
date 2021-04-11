using System;
using System.Collections.Generic;

#nullable disable

namespace MyMeals.Models
{
    public partial class Adres
    {
        public Adres()
        {
            Gebruikers = new HashSet<Gebruiker>();
        }

        public int AdresId { get; set; }
        public string Straat { get; set; }
        public string Huisnummer { get; set; }
        public string Postcode { get; set; }
        public string Woonplaats { get; set; }

        public virtual ICollection<Gebruiker> Gebruikers { get; set; }
    }
}
