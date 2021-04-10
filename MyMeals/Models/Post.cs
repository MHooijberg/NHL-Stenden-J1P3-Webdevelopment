using System;
using System.Collections.Generic;

#nullable disable

namespace MyMeals.Models
{
    public partial class Post
    {
        public int PostId { get; set; }
        public string PostNaam { get; set; }
        public int GebruikerId { get; set; }
        public int MaaltijdId { get; set; }
        public int Bevroren { get; set; }
        public DateTime BereidOp { get; set; }
        public DateTime HoudbaarTot { get; set; }
        public int Porties { get; set; }
        public double? Prijs { get; set; }
        public string Beschrijving { get; set; }

        public virtual Gebruiker Gebruiker { get; set; }
        public virtual Maaltijd Maaltijd { get; set; }
    }
}
