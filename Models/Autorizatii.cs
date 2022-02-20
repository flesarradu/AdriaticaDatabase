using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Autorizatii
    {
        int IdAutorizatie { get; set; }
        String SeriaAutorizatie { get; set; }
        int IdTaraAutorizatie { get; set; }
        Lista_Tari TaraAutorizatie { get; set; }
        DateTime DataCumparareAutorizatie { get; set; }
        DateTime DataEmitereAutorizatie { get; set; }
        DateTime DataExpirareAutorizatie { get; set; }
        int IdNumarSoferAutorizatie { get; set; }
        Angajati_Detalii NumarSoferAutorizatie { get; set; }
        int IdCuplajAutorizatie { get; set; }
         Lista_NrAuto_Masini_Proprii CuplajAutorizatie { get; set; }
        DateTime DataDatCatreSoferAutorizatie { get; set; }
        DateTime DataPrimireDeLaSoferAutorizatie { get; set; }
        bool DatLaSoferAutorizatie { get; set; }
        bool PrimitDeLaSoferAutorizatie { get; set; }
        DateTime DataPredareAsociatie { get; set; }
        bool PredatLaAsociatie { get; set; }
        String ObservatiiAutorizatie { get; set; }
        bool AnulareAutorizatie { get; set; }
        int IdTipAutorizatie { get; set; }
        Lista_Tipuri_Autorizatii TipAutorizatie { get; set; }
        double CostAutorizatie { get; set; }
        int IdValutaAutorizatie { get; set; }
        Lista_Valute ValutaAutorizatie { get; set; }
    }
}
