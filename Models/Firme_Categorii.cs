using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Firme_Categorii
    {
        int IdCategorieFirma { get; set; }
        int IdFirmaCF { get; set; }
        Firme FirmaCF { get; set; }
        int IdCategorieCF { get; set; }
        Lista_Categorii_Firme CategorieCF { get; set; }
    }
}
