using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Alte_Conturi_Bancare
    {
        int IdFirma { get; set; }
        Firme Firma { get; set; }
        int IdBanca { get; set; }
        Lista_Banci Banca { get; set; }
        int IdFirmePropriiConturi { get; set; }
        Firme_Proprii_Conturi FirmePropriiConturi { get; set; }

    }
}
