using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Taxe_Indirecte_Simulare
    {
        int IdTaxeIndir { get; set; }
        int IdTaxeIndirSimualare { get; set; }
        int IdDenumireTaxeIndirSimulare { get; set; }
        Lista_CC_Decont_Cursa DenumireTaxeIndirSimulare { get; set; }
        double ValoareDenumireTaxeIndirSimulare { get; set; }
    }
}
