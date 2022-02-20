using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Curse
    {
        int IdCursa { get; set; }
        String CodCursa { get; set; }
        DateTime DataCursa { get; set; }
        DateTime OraCursa { get; set; }
        bool ProprieIntermedCursa { get; set; }
        bool RezolvataCursa { get; set; }
        DateTime DataRezAnulCursa { get; set; }
        DateTime OraRezAnulCursa { get; set; }
        String ObservatiiCursa { get; set; }
        double TotalClientiCursa { get; set; }
        double TotalCarausCursa { get; set; }
        double ComBancarCursa { get; set; }
        double ProfitCursa { get; set; }
        double TarifFCarausCursaCuTVA { get; set; }
        int IdCotaTVATarifCaraus { get; set; }
        Lista_Cota_TVA CotaTVATarifCaraus { get; set; }
        double TarifFCarausCursa { get; set; }
        double TarifFinalCursa { get; set; }
        String ObservatiiTarifCursa { get; set; }
        int IdMonedaTarifFCarausCursa { get; set; }
        Lista_Valute MonedaTarifFCarausCursa { get; set; }
        DateTime DataCalculCursa { get; set; }
        double RestPlataCursa { get; set; }
        bool RestPlataActualizareCursa { get; set; }
        double MonRefPlataCursa { get; set; }
        int ExternaInternaCursa { get; set; }
        DateTime DataDeblocareCursa { get; set; }
        bool ActualizareFinanciaraCursa { get; set; }
        String ObservatiiDeblocareCursa { get; set; }
        bool FacturataCursa { get; set; }
        String RegimTransport { get; set; }
        int IdDispecerCursa { get; set; }
        Firme_Persoane_Contact DispecerCursa { get; set; }
        int IdCarausCursa { get; set; }
        Firme CarausCursa { get; set; }
        int IdNrAuto1PropriiCursa { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto1PropriiCursa { get; set; }
        int IdNrAuto2PropriiCursa { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto2PropriiCursa { get; set; }
        String NrAutoIntermediareCursa { get; set; }
        int IdSofer1PropriiCursa { get; set; }
        Firme_Persoane_Contact Sofer1PropriiCursa { get; set; }
        int IdSofer2PropriiCursa { get; set; }
        Firme_Persoane_Contact Sofer2PropriiCursa { get; set; }
        String SoferiIntermedieriCursa { get; set; }
        String NrTelSoferCursa { get; set; }
        int TermenDePlataCaraus { get; set; }
        int IdPersoanaContactCursa { get; set; }
        Firme_Persoane_Contact PersoanaContactCursa { get; set; }
        int TarifExternInternCursa { get; set; }
        int NrKmCursa { get; set; }
        double TarifulCursa { get; set; }


    }
}
