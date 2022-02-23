using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Masini_Proprii_Detalii
    {
        int IdNrInmatriculareFCT { get; set; }
        Lista_NrAuto_Masini_Proprii NrInmatriculareFCT { set; get; }
        int IdMarcaFCT { get; set; }
        Lista_Marci_Masini MarcaFCT { set; get; }
        int AsigurareFCT { get; set; }
        String NrSasiuFCT { get; set; }
        DateTime DataFabricatie { get; set; }
        String CuloareFCT { get; set; }
        String NumeCodFCT { get; set; }
        int IdSoferTitularFCT { get; set; }
        Firme_Persoane_Contact SoferTitulatFCT { get; set; }
        DateTime ScadentaLicentaFCT { get; set; }
        DateTime ScadentaAgreereVamalaFCT { get; set; }
        DateTime ScadentaITPFCT { get; set; }
        DateTime ScadentaRCAFCT { get; set; }
        DateTime ScadentaAsigurareFCT { get; set; }
        DateTime ScadentaImpozitFCT { get; set; }
        String SerieMotorFCT { get; set; }
        int CilindreeFCT { get; set; }
        int PutereMotorFCT { get; set; }
        int IdTipFCT { get; set; }
        Lista_Tipuri_CT TipFCT { get; set; }
        int IdFelFCT { get; set; }
        Lista_Feluri_CT FelFCT { get; set; }
        int VolumUtilFCT { get; set; }
        int SarcinaUtilaFCT { get; set; }
        int LungimeUtilaFCT { get; set; }
        int LatimeUtilaFCT { get; set; }
        int InaltimeUtilaFCT { get; set; }
        bool ProductivaFCT { get; set; }
        int CapacitateRezervorFCT { get; set; }
        int IdPerecheAutoFCT { get; set; }
        Lista_NrAuto_Masini_Proprii PerecheAutoFCT { get; set; }
        String IncadrareClasaFCT { get; set; }
        String ClasaADRFCT { get; set; }
        DateTime ScadentaLarmasFCT { get; set; }
        DateTime ScadentaADRFCT { get; set; }
        DateTime ScadentaCertifInmatFCT { get; set; }
        String ObservatiiFCT { get; set; }
        DateTime DataAchizitieFCT { get; set; }
        int KmBordFCT { get; set; }
        int CapacitateRezervorTermokingFCT { get; set; }
        DateTime ScadentaAE3FCT { get; set; }
        double ConsumInstalatieAuxFCT { get; set; }
        DateTime DataIncInstalatieAuxFCT { get; set; }  
        DateTime DataSfInstalatieAuxFCT { get; set; }
        bool MasinaExportataServiceFCT { get; set; }
        DateTime ScadentaRovignetaFCT { get; set; }
        String SerieRovignetaFCT { get; set; }
        String SerieCertifInmatFCT { get; set; }
        String SerieAgreereFCT { get; set; }
        String SerieLicentaFCT { get; set; }
        String SerieLarmasFCT { get; set; }
        String SerieAsigurareFCT { get; set; }
        String SerieRCAFCT { get; set; }
        String SerieTahografFCT { get; set; }
        String SerieAE3FCT { get; set; }
        bool RadiataFCT { get; set; }
        double MasaProprieFCT { get; set; }
        double MasaMaximaAutorizataFCT { get; set; }
        double MasaUtilaFCT { get; set; }
        String DimensiuneAnvelopeFataFCT { get; set; }
        String DimensiuneAnvelopeMijlocSpateFCT { get; set; }
        bool LeasingFCT { get; set; }
        bool InchiriataFCT { get; set; }


    }
}
