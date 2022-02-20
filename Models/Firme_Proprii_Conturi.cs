using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Firme_Proprii_Conturi
    {
        int IdPropriiConturi { get; set; }
        int IdFirma { get; set; }
        Firme Firma { get; set; }
        int IdBanca { get; set; }
        Lista_Banci Banca { get; set; }
        int IdValuta { get; set; }
        Lista_Valute Valuta { get; set; }
        String ContFirma { get; set; }
        String SwiftCode { get; set; }
        bool ContActiv { get; set; }
        int IdContAnalitic { get; set; }
        Lista_Conturi ContAnalitic { get; set; }
        bool ContDeCredit { get; set; }
    }
}
