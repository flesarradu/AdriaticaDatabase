using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Carnete_TIR
    {
        int IdCarnetTIR { get; set; }
        String SeriaCarnetTIR { set; get; }
        DateTime DataCumparareCarnetTIR { set; get; }
        DateTime DataEmitereCarnetTIR { set; get; }
        DateTime DataExpirareCarnetTIR { set; get; }
        int IdNumeSoferCarnetTIR { set; get; }
        Angajati_Detalii NumeSoferCarnetTIR { set; get; }
        int IdCuplajCarnet { set; get; }
        Lista_NrAuto_Masini_Proprii CuplajCarnet { get; set; }
        DateTime DataCatreSoferCarnetTIR { set; get; }
        DateTime DataPrimireSoferCarnetTIR { set; get; }
        bool DatLaSoferCarnetTIR { set; get; }
        bool PrimitSoferCarnetTIR { set; get; }
        DateTime DataPredareAsociatie { set; get; }
        bool PredatLaAsociatie { set; get; }
        String Observatii { set; get; }
        bool AnulareCarnetTIR { get; set; }
        double CostCarnetTir { set; get; }
        int IdValutaCarnetTIR { get; set; }
        Lista_Valute ValutaCarnetTIR { get; set; }

    }
}
