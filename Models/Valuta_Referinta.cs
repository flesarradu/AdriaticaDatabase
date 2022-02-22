using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Valuta_Referinta
    {
        int IdValutaReferinta { get; set; }
        int IdListaValuteReferinta { get; set; }
        Lista_Valute Lista_ValuteReferinta { get; set; }
        String ValutaReferinta { get; set; }
    }
}
