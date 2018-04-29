using System;

namespace Oefening13_8
{
    public class Persoon
    {
        public string Naam { get; set; }
        public string VoorNaam { get; set; }
        public GeslachtEnum Geslacht { get; set; }
        public string Adres { get; set; }
        public DateTime GeboorteDatum { get; set; }

        public Persoon(string naam, string voorNaam, GeslachtEnum geslacht, string adres, DateTime geboorteDatum)
        {
            Naam = naam;
            VoorNaam = voorNaam;
            Geslacht = geslacht;
            Adres = adres;
            GeboorteDatum = geboorteDatum;
        }

        public override string ToString()
        {
            return VoorNaam + " " + Naam;
        }
    }
}