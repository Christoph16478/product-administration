using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktverwaltung.Entities
{
    /// <summary>Database table mapped as class <c>Produkt</c>.</summary>
    public class Produkt
    {
        public int ProduktId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string Kategorie { get; set; }
        public int MengeProEinheit { get; set; }
        public float PreisProEinheit { get; set; }
        public int EinheitAufLager { get; set; }
        public int EinheitVorbestellt { get; set; }
        public int NachbestellungsStufe { get; set; }
        public string ProduktionEingestellt { get; set; }
    }
}
