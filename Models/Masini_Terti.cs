using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Masini_Terti
    {
        int IdMasinaMT { get; set; }
        int IdFirmaTertiMT { get; set; }
        Firme FirmaTertiMT { get; set; }
        String NumarInmatriculareMT { get; set; }
        int IdMarcaMT { get; set; }
        Lista_Marci_Masini MarcaMT { get; set; }
        int IdSoferTitularMT { get; set; }
        Firme_Persoane_Contact SoferTitularMT { get; set; }
        int IdTipMT { get; set; }
        Lista_Tipuri_CT TipMT { get; set; }
        int IdFelMT { get; set; }
        Lista_Feluri_CT FelMT { get; set; }
        int VolumUtilMT { get; set; }
        int SarcinaUtilaMT { get; set; }
        int LungimeUtilaMT { get; set; }
        int LatimeUtilaMT { get; set; }
        int InaltimeUtilaMT { get; set; }
        int IdPerecheAutoMT { get; set; }
        Masini_Terti PerecheAutoMT { get; set; }
        bool Anulata { get; set; }

    }
}
