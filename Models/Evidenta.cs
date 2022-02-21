using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Evidenta
    {
        int IdEvidenta { get; set; }
        int NumarFisa { get; set; }
        int IdNumeAngajat { get; set; }
        Firme_Capacitati_Transport NumeAngajat { get; set; }
        int ZiuaReparatie { get; set; }
        int LunaReparatie { get; set; }
        int AnReparatie { get; set; }
        bool FisaIncheiata { get; set; }
        DateTime DataReparatie { get; set; }

    }
}
