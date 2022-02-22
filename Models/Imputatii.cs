using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Imputatii
    {
        int IdImputatii { get; set; }
        String NrDocImp { get; set; }
        int IdPersoanaImputatii { set; get; }
        Firme_Persoane_Contact PersoanaImputatii { set; get; }
        DateTime DataImputatii { set; get; }
        int IdCodCursaImputatii { set; get; }
        Curse CodCursaImputatii { get; set; }
        double SumaFaraTVAImp { set; get; }
        double SumaTVAImp { set; get; }
        double SumaCuTVAImp { set; get; }
        int IdValutaImputatii { set; get; }
        Lista_Valute ValutaImputatii { get; set; }
        double CursValutarImp { set; get; }
        int IdTVAImp { get; set; }
        Lista_Cota_TVA TVAImp { get; set; }
        int IdDenumireOperatiune { set; get; }
        Lista_Operatiuni_Jurnale DenumireOperatiune { get; set; }
        int TipJurnal { set; get; }
        int IdTipTVACump { set; get; }
        Lista_Tip_TVA_Cumparari TipTVACump { get; set; }
        int IdTipTVAVanz { set; get; }
        Lista_Tip_TVA_Vanzari TipTVAVanz { get; set; }
        int IdContDebitImp { set; get; }
        Lista_Conturi ContDebitImp { set; get; }
        int IdContCreditImp { set; get; }
        Lista_Conturi ContCreditImp { set; get; }
        int IdContTVAImp { set; get; }
        bool BalantaBlocata { set; get; }
        double SumaFaraTVAImpRON { set; get; }
        double SumaTVAImpRon { set; get; }
        double SumaCuTVAImpRon { get; set; }
        String ComputerName { set; get; }
        DateTime DataIntroduceriiImp { set; get; }
        DateTime OraIntroduceriiImp { set; get; }
        int IdFirmaImp { set; get; }
        Firme FirmaImp { get; set; }
    }
}
