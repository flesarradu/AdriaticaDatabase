using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Masini_Terti_Detalii
    {
        int IdNumarAutoTerti { get; set; }
        Lista_NrAuto_Masini_Proprii NumarAutoTerti { get; set; }
        int IdProprietarTerti { get; set; }
        Firme ProprietarTerti { get; set; }
        String ProprietarPersFizicaTerti { get; set; }
        int IdNrAutoTerti { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoTerti { get; set; }
        int IdMarcaFCT { get; set; }
        Lista_Marci_Masini MarcaFCT { get; set; }
        String CuloareFCT { get; set; }
        String NumeCodFCT { get; set; }
        DateTime DataRevizieTehnica { get; set; }
        DateTime DataScadentaService { get; set; }
        String Categorie { get; set; }
        String Caroserie { get; set; }
        String Tip_Varianta { get; set; }
        int AnFabricatie { get; set; }
        String NumarIdentificare { get; set; }
        int MasaProprie { get; set; }
        int MasaTotalaMaxAut { get; set; }
        int MasaMaxAutAxeFata { get; set; }
        int MasaMaxAutAxeSpate { get; set; }
        int MasaMaxAutAxeMijloc { get; set; }
        int MasaMaxAutAxeRoleSenila { get; set; }
        int MasaRemorcabilaCuDispFranare { get; set; }
        int MasaRemorcabilaFaraDispFranare { get; set; }
        int NrLocuriTotal { get; set; }
        int NrLocuriFata { get; set; }
        int NrLocuriScaune { get; set; }
        int NrLocuriInPicioare { get; set; }
        String MotorTip { get; set; }
        String SerieMotorFCT { get; set; }
        int CilindreeFCT { get; set; }
        int PutereMotorFCT { get; set; }
        String MotorSursaEnergie { get; set; }
        int IdTipFCT { get; set; }
        Lista_Tipuri_CT TipFCT { get; set; }
        int IdFelFCT { get; set; }
        Lista_Feluri_CT FelFCT { get; set; }
        int VolumUtilFCT { get; set; }
        int SarcinaUtilaFCT { get; set; }
        int SarcinaUtilaCarligRemorcare { get; set; }
        int LungimeUtilaFCT { get; set; }
        int LatimeUtilaFCT { get; set; }
        int InaltimeUtilaFCT { get; set; }
        int NumarAxe { get; set; }
        String Tractiune { get; set; }
        String DimensiuneAnvelopeFata { get; set; }
        String DimensiuneAnvelopeMijlocSpate { get; set; }
        int CapacitateRezervorFCt { get; set; }
        String ObservatiiFCT { get; set; }
        DateTime DataAchizitieFCT { get; set; }
        int KmBordFCT { get; set; }
        bool AnulareMasinaTerti { get; set; }
        String IncadrareClasaFCT { get; set; }
        String ClasaADRFCT { get; set; }
        DateTime DataFabricatieFCT { get; set; }
        String NrSasiuFCT { get; set; }
        DateTime ScadentaLicentaFCT { get; set; }
        DateTime ScadentaAgreereVamalaFCT { get; set; }
        DateTime ScadentaITPFCT { get; set; }
        DateTime ScadentaRCAFCT { get; set; }
        DateTime ScadentaAsigurareFCT { get; set; }
        DateTime ScadentaImpozitFCT { get; set; }
        DateTime ScadentaLarmasFCT { get; set; }
        DateTime ScadentaADRFCT { get; set; }
        DateTime ScadentaCertifInmatFCT { get; set; }
        DateTime ScadentaRovignetaFCT { get; set; }
        DateTime ScadentaTahografFCT { get; set; }
        DateTime ScadentaAE3FCT { get; set; }
        String SerieRovignetaFCT { get; set; }
        String SerieCertifInmatFCT { get; set; }
        String SerieAgreereFCT { get; set; }
        String SerieLicentaFCT { get; set; }
        String SerieLarmasFCT { get; set; }
        String SerieAsigurareFCT { get; set; }
        String SerieRCAFCT { get; set; }
        String SerieTahografFCT { get; set; }
        String SerieAE3FCT { get; set; }
        int CapacitateRezervorTermokingFCT { get; set; }
        double ConsumInstalatieAuxFC { get; set; }
    }
}
