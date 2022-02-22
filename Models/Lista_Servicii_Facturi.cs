using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Servicii_Facturi
    {
        int IdArticol { get; set; }
        String DenumireArticol { get; set; }
        int IdContDebit { get; set; }
        Lista_Conturi ContDebit { get; set; }
        int IdContCredit { get; set; }
        Lista_Conturi ContCredit { get; set; }
        bool FacturaEmisa { get; set; }
        bool FacturiPrimite { get; set; }
    }
}
