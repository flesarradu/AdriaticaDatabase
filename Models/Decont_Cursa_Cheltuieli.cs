using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Decont_Cursa_Cheltuieli
    {
        int IdDecontCursaCheltuieli { get; set; }
        int IdInchidereAvansDCCLink { get; set; }
        Inchidere_Avansuri InchidereAvansDCCLink { set; get; }
        String NrDCCheltuieli { set; get; }
        DateTime DataDecontDCCheltuieli { set; get; }
        int IdDecontCursaGeneralCheltuieli { set; get; }
        Decont_Cursa_General DecontCursaGeneralCheltuieli { set; get; }
        int IdTaraDCCheltuieli { set; get; }
        Lista_Tari TaraDCCheltuieli { get; set; }
        DateTime DataDCCheltuieli { set; get; }
        int IdClasaDCCheltuieli { set; get; }
        Lista_CC_Decont_Cursa ClasaDCCheltuieli { get; set; }
        double SumaDCCheltuieli { set; get; }
        int IdMonedaDCCheltuieli { set; get; }
        Lista_Valute MonedaDCCheltuieli { get; set; }
        double MonRefSumaDCCheltuieli { set; get; }
        String ExplicatiiDCCheltuieli { get; set; }
        int IdPersoanaDCCheltuieli { get; set; }
        Firme_Persoane_Contact PersoanaDCCheltuieli { get; set; }
        bool NumerarDCCheltuieli { set; get; }
        bool AnulareDCCheltuieli { set; get; }
        String NrDocumentDCCheltuieli { get; set; }
        double SumaInLeiDCCheltuieli { get; set; }
        double ValoareFaraTVADCCheltuieli { get; set; }
        double ValoareTVADCCheltuieli { get; set; }
        int IdFurnizorDCCheltuieli { get; set; }
        Firme FurnizorDCCheltuieli { get; set; }
        int IdCotaTVADCCheltuieli { get; set; }
        Lista_Cota_TVA CotaTVADCCheltuieli { get; set; }
        double MonRefSumaFaraTVADCCheltuieli { get; set; }
        bool ExportContabilitateDCCheltuieli { get; set; }
        double LitriiCombustibilDCCheltuieli { get; set; }
        int IdTipDocument { get; set; }
        Lista_Documente_Fiscale TipDocument { get; set; }
        int IdTipCard { get; set; }
        Lista_Tip_Card TipCard { get; set; }
        bool CLaNDCcheltuieli { get; set; }
        DateTime DataIntroduceriiDCCheltuieli { get; set; }
        DateTime OraIntroduceriiDCCheltuieli { get; set; }
        bool InJurnalDCCheltuieli { get; set; }
        bool CardDCCheltuieli { get; set; }
        int IdTipTVADCCheltuieli { get; set; }
        Lista_Tip_TVA_Cumparari TipTVADCCheltuieli { get; set; }
        int IdContDebitDCCheltuieli { get; set; }
        Lista_Conturi ContDebitDCCheltuieli { get; set; }
        int IdContCreditDCCheltuieli { get; set; }
        Lista_Conturi ContCreditDCCheltuieli { get; set; }

    }
}
