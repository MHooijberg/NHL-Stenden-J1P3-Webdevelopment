using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MyMeals.Pages
{
    public class OverOnsModel : PageModel
    {
        public string AboutUs { get; set; }
        public string Disclaimer { get; set; }

        public void OnGet()
        {
            DefaultValues();
        }

        private void DefaultValues()
        {
            AboutUs = "Wij zijn een groep jonge ondernemers die zagen hoe veel eten er dagelijks wordt weggegooid, terwijl om de hoek iemand daar " +
                "nog een maaltijd aan zou kunnen hebben, en dit gebeurde alleen omdat mensen dit niet van elkaar wisten, dus bedachten we MyMeals, " +
                "een platform waar té fanatieke koks en luie lekkerbekken elkaar kunnen ontmoeten, zodat geen enkele maaltijd verlroen hoeft te gaan.";
            Disclaimer = "Dit is een schoolopdracht uitgevoerd door groep 5 van klas 1B van de HBO-ICT opleiding van NHLstenden Leeuwarden. Meningen " +
                "geuit in interviews en commentaren zijn puur opgenomen voor hun amusementswaarde en zijn niet afkomstig van NHLstenden of de makers " +
                "van deze site.";
        }
    }
}
