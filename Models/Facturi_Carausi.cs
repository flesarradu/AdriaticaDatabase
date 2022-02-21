using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Facturi_Carausi
    {
        int IdFacturaCaraus { get; set; }
        int IdCumparatorFCaraus { get; set; }
        Firme CumparatorFCaraus { set; get; }
        int IdFurnizorFCaraus { get; set; }
        Firme FurnizorFCaraus { set; get; }
        bool AnulataFCaraus { set; get; }
        int IdValutaFCaraus { set; get; }
        Lista_Valute ValutaFCaraus { set; get; }
        String NumarFCaraus { set; get; }
        DateTime DataFCaraus { set; get; }
        int IdTVAFCaraus { set; get; }
        Lista_Cota_TVA TVAFCaraus { set; get; }
        double TotalValFCaraus { set; get; }
        double TotalValTVAFCaraus { get; set; }
        double TotalFCaraus { set; get; }
        DateTime DataIntrareFCaraus { set; get; }
        DateTime DataIntrareCMRAviz { set; get; }
        int TermenDePlataFCaraus { get; set; }
        bool PlatitaFact { set; get; }
        String ObservatiiFCaraus { set; get; }
        bool FacturaDeLaCaraus { get; set; }
        double RestPlataFCaraus { get; set; }
        int IdPersoanaIntocmireFCaraus { set; get; }
        Firme_Persoane_Contact PersoanaIntocmireFCaraus { set; get; }
        bool RestTrPlataFCaraus { set; get; }
        DateTime DataPlatiiIntegraleFcaraus { set; get; }
        double BazaDeImpozitareLeiFCaraus { set; get; }
        double TotalTVALeiFCaraus { set; get; }
        double TotalFactLeiFCaraus { set; get; }
        double RestEur { set; get; }
        DateTime ScadentaFact { set; get; }
        bool NuCashFlowFC { set; get; }
        DateTime DataIntroduceriiFCaraus { get; set; }
        DateTime OraIntroduceriiFCaraus { get; set; }
        bool NuInJurnalFCaraus { set; get; }
        bool NuInJurnalCumparari { set; get; }
        double CursValFCaraus { set; get; }
        bool BlocareFCaraus { set; get; }
        bool FacturaDinServiceFact { set; get; }
        double SumaAchitataFCaraus { get; set; }
        bool CompensareFCaraus { get; set; }
        bool NuInManagementFCaraus { set; get; }
        bool SoldInitialFCaraus { set; get; }
        bool BalantaEmisaFCaraus { set; get; }
        bool RulajAnteriorFCaraus { set; get; }
        double SumaDorita { set; get; }
        int IdValutaDorita { set; get; }
        Lista_Valute ValutaDorita { get; set; }
        double CursulDorit { set; get; }
        double DiferentaDeCurs { set; get; }
        double TotalValFCarausEUR { set; get; }
        double TotalValTVAFCarausEUR { set; get; }
        double TotalValLeiVechiFCaraus { set; get; }
        double TotalValTVALeiVechiFCaraus { set; get; }
        double TotalLeiVechiFCaraus { get; set; }
        double RestPlataLeiVechiFCaraus { set; get; }
        int IdValutaVecheFCaraus { set; get; }
        Lista_Valute ValutaVecheFCaraus { set; get; }
        double CursValFCarausVechiReevaluare { set; get; }
        int IdTipTVAFCaraus { set; get; }
        Lista_Tip_TVA_Cumparari TipTVAFCaraus { get; set; }
        bool TaxareInversa { set; get; }
        double CursulDoritAltaValuta { set; get; }
        double SumaDoritaEchLEI { set; get; }
        int IdContFurnizorFCaraus { set; get; }
        Lista_Conturi ContFurnizorFCaraus { set; get; }
        bool ExportataInParcAuto { set; get; }
        double CursVal_31_12 { set; get; }


    }
}
