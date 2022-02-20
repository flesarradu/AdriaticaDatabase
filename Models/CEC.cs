using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class CEC
    {
        int IdCEC { get; set; }
        DateTime DataCEC { get; set; }
        int TipOperatiuneCEC { get; set; }
        int TipCEC { get; set; }
        String NrCEC { get; set; }
        int IdFirmaCEC { get; set; }
        Firme FirmaCEC { get; set; }
        double SumaCEC { get; set; }
        int IdValutaCEC { get; set; }
        Lista_Valute ValutaCEC { get; set; }
        DateTime DataScadentaCEC { get; set; }
        int IdBancaCEC { get; set; }
        Lista_Banci BancaCEC { get; set; }
        bool IncasatAchitat { get; set; }
    }
}
