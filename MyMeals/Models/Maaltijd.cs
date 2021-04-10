using System;
using System.Collections.Generic;

#nullable disable

namespace MyMeals.Models
{
    public partial class Maaltijd
    {
        public Maaltijd()
        {
            Posts = new HashSet<Post>();
        }

        public int MaaltijdId { get; set; }
        public string Naam { get; set; }
        public int GebruikerId { get; set; }
        public string Ingredienten { get; set; }
        public int Vegetarisch { get; set; }
        public int AfbeeldingId { get; set; }

        public virtual Gebruiker Gebruiker { get; set; }
        public virtual ICollection<Post> Posts { get; set; }
    }
}
