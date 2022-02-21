using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Decont_ParcAuto_Cheltuieli
    {
        int IdDecontPACheltuieli { get; set; }
        int IdInchidereAvansCPALink { get; set; }
        Inchidere_Avansuri InchidereAvansCPALink { set; get; }
        int IdMasinaLink { get; set; }
        Lista_NrAuto_Masini_Proprii MasinaLink { get; set; }
        DateTime DataCheltuiala { get; set; }
        double SumaDPAC { get; set; }
        int IdMonedaDPAC { get; set; }
        Lista_Valute MonedaDPAC { set; get; }
        int IdClasaCPAuto { get; set; }
        Lista_CC_PAuto ClasaCPAuto { set; get; }
        int IdSubClasaCPAuto { get; set; }
        Lista_CC_Subclasa_PAuto SubClasaCPAuto { set; get; }
        String ExplicatiiDPAC { get; set; }
        DateTime DataDecontPAC { get; set; }
        String NrDecontPAC { get; set; }
        int IdPersoanaDPAC { get; set; }
        Firme_Persoane_Contact PersoanaDPAC { set; get; }
        int KmBordDPAC { get; set; }
        double SumaMonedaRefDPAC { get; set; }
        bool NumerarDPAC { get; set; }
        bool AnulareDPAC { get; set; }
        double SumaInLeiDPAC { get; set; }
        double ValoareFaraTVA { get; set; }
        double ValoareTVADPAC { get; set; }
        int IdFurnizorDPAC { get; set; }
        Firme FurnizorDPAC { set; get; }
        int IdCotaTVADPAC { get; set; }
        Lista_Cota_TVA CotaTVADPAC { set; get; }
        double MonRefSumaFaraTVADPAC { get; set; }
        bool ExportContabilitateDPAC { get; set; }
        String NrDocumentDPAC { get; set; }
        double TotalCheltuieliFaraTVADPAC { get; set; }
        int IdTipDocumentDPAC { get; set; }
        Lista_Documente_Fiscale TipDocumentDPAC { set; get; }
        int IdDenumireProduBonConsDPAC { get; set; }
        Lista_Produse DenumireProdusBonConsDPAC { set; get; }
        bool ExportatTransporturi { get; set; }
        String NrBonConsumDPAC { get; set; }
        bool BalantaEmisaDPAC { get; set; }
        bool InJurnalDPAC { set; get; }
        int IdBonConsDPAC { get; set; }
        Bon_De_Consum BonConsDPAC { get; set; }
        int IdTipTVADPAC { get; set; }
        Lista_Tip_TVA_Cumparari TipTVADPAC { get; set; }
        bool RegieAutoDPAC { get; set; }
        int IdFacturaPrimita { get; set; }
        Id_Facturi_Primite FacturaPrimita { set; get; }

    }
}
