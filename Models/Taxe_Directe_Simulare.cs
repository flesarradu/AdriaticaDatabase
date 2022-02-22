using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Taxe_Directe_Simulare
    {
        int IdTaxeDir { get; set; }
        int IdTaxeDirSimulare { get; set; }
        int IdDenumireTaxeDirSimulare { get; set; }
        Lista_CC_Decont_Cursa DenumireTaxeDirSimulare { get; set; }
        double ValoareTaxeDirSimulare { get; set; }
    }
}
