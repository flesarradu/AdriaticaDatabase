using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Facturi_Emise
    {
        int IdFactura { get; set; }
        int IdFurnizor { get; set; }
        Firme Furnizor { get; set; }
        int IdCumparator { get; set; }
        Firme Cumparator { get; set; }
        int IdValuta { get; set; }
        Lista_Valute Valuta { get; set; }
        bool AnulataFact { get; set; }
        String NumarFact { get; set; }
        DateTime DataFact { get; set; }
        String NrAvizFact { get; set; }
        int IdTVAFact { get; set; }
        Lista_Cota_TVA TVAFact { get; set; }
        double TotalValFact { get; set; }
        double TotalValTVAFact { get; set; }
        double TotalFact { get; set; }
        DateTime DataIersireFact { get; set; }
        DateTime DataIesireCMRAviz { get; set; }
        int TermenDeIncasareFact { get; set; }
        bool IncasataFact { get; set; }
        double RestIncasareFact { get; set; }
        int IdPersoanaIntocmireFact { get; set; }
        Firme_Persoane_Contact PersoanaIntocmireFact { get; set; }
        String ObservatiiFact { get; set; }
        bool RestTrIncasareFact { get; set; }
        DateTime DataIncasareIntegralaFact { get; set; }
        int IdNrAuto1Fact { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto1Fact { get; set; }
        int IdNrAuto2Fact { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto2Fact { get; set; }
        DateTime DataExpediereFact { get; set; }
        DateTime OraExpediereFact { get; set; }
        double BazaDeImpozitareLeiFact { get; set; }
        double TotalTVALeiFact { get; set; }
        double TotalFactLeifact { get; set; }
        double CursValFact { get; set; }
        int IdDelegatProrpiuFact { get; set; }
        Angajati_Detalii DelegatPropriuFact { get; set; }
        String DelegatTertiFact { get; set; }
        String NrBIDelegatTertiFact { get; set; }
        String SerieBIDelegatiTertiFact { get; set; }
        String CNPDelegatTertiFact { get; set; }
        String EliberatBIDelegatTertiFact { get; set; }
        String NrAuto1TertiFact { get; set; }
        String NrAuto2TertiFact { get; set; }
        double RestEur { get; set; }
        DateTime ScadentaFact { get; set; }
        DateTime DataIntroduceriiFact { get; set; }
        DateTime OraIntroduceriiFact { get; set; }
        bool NuInJurnalFact { get; set; }
        bool NuInJurnal { get; set; }
        double SumaAchitataFact { get; set; }
        bool FacturaDinServiceFact { get; set; }
        bool CompensareFact { get; set; }
        bool SoldInitialFact { get; set; }
        bool BalantaEmisaFact { get; set; }
        bool RulajAnterior { get; set; }
        bool FaraDreptDeDeducere { get; set; }
        double RabatGeneralFact { get; set; }
        double RabatDinProduseFact { get; set; }
        double RabatTVADinProduseFact { get; set; }
        double TotalValFactCuRabat { get; set; }
        double TotalValTVAFactCuRabat { get; set; }
        double TotalFactCuRabat { get; set; }
        double TotalDinProduseFaraTVA { get; set; }
        double TotalDinProduseCuTVA { get; set; }
        bool ProduseDinNiruriFact { get; set; }
        bool FacturaActualizataFM { get; set; }
        bool FacturaAltele { get; set; }
        bool FacturaITP { get; set; }
        int IdNrAutoFacturatiITP { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoFacturatiITP { get; set; }
        bool FacturaBlocata { get; set; }
        bool BonFiscalEmis { get; set; }
        int NrBonFiscal { get; set; }
        bool OptiuneSelectataBon { get; set; }
        bool OptiuneSelectataFactura { get; set; }
        double SumaDorita { get; set; }
        int IdValutaDorita { get; set; }
        Lista_Valute ValutaDorita { get; set; }
        double CursulDorit { get; set; }
        double DiferentaDeCurs { get; set; }
        double TotalValFactEUR { get; set; }
        double TotalValTVAFactEUR { get; set; }
        double TotalValLeiVechiFact { get; set; }
        double TotalValTVALeiVechiFact { get; set; }
        double TotalFactLeiVechi { get; set; }
        double RestIncasareLeiVechiFact { get; set; }
        int IdValutaVecheFact { get; set; }
        Lista_Valute ValutaVecheFact { get; set; }
        double CursValFactVecheReevaluare { get; set; }
        int IdGestiuneFact { get; set; }
        Lista_Gestiuni GestiuneFact { get; set; }
        int TipTVAFactE { get; set; }
        bool AfisareConversieFact { get; set; }
        int IdTipTVAFact { get; set; }
        Lista_Tip_TVA_Vanzari TipTVAFact { get; set; }
        double CursFact { get; set; }
        int IdValutaCurs { get; set; }
        Lista_Valute ValutaCurs { get; set; }
        double CursulDoritAltaValuta { get; set; }
        double SumaDoritaEchLEI { get; set; }
        int IdContClientFact { get; set; }
        Lista_Conturi Cont_ClientFact { get; set; }
        bool ChitantaEmisa { get; set; }
        double Cursval_31_12 { get; set; }

    }
}
