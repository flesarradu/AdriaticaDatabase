using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Masini_Proprii_Detalii_Alte_Scadente
    {
        int IdMasina { get; set; }
        DateTime Scadenta { get; set; }
        String ObsScadenta { get; set; }
        String Serie { get; set; }
    }
}
