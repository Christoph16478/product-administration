using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Produktverwaltung.ModelView
{
    /// <summary>Adaptation of the entity classes to the
    /// UI by the class <c>ProduktView</c>.</summary>
    public class ProduktView
    {
        public int ProduktId { get; set; }
        public string Name { get; set; }
        public string Beschreibung { get; set; }
        public string Kategorie { get; set; }
    }
}
