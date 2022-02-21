using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Decont_Cursa_General
    {
        int IdDecontCursaGeneral { get; set; }
        int IdCursaDCGeneral { get; set; }
        Curse CursaDCGeneral { get; set; }
        double TotalCheltuieliDCGeneral { get; set; }
        DateTime DataDCGeneral { get; set; }
        String ObsDCGeneral { get; set; }
        bool VerificatDCGeneral { get; set; }
        int IdPersoanaIntocmireDCGeneral { get; set; }
        Angajati_Detalii PersoanaIntocmireDCGeneral { get; set; }
        bool FinalizatDCGeneral { get; set; }
        double CostPeKmDCGeneral { get; set; }
        double RegularizareDCGeneral { get; set; }
        DateTime DataDeblocareDecont { get; set; } 
        String ObservatiiDeblocareDecont { get; set; }
        double TotalCheltuieliInLeiDCGeneral { get; set; }
        int TotalKmParcursiDCGeneral { get; set; }
        int TotalKmInterniDCGeneral { get; set; }
        int TotalKmExterniDCGeneral { get; set; }
        double TotalCheltuieliInLeiFaraTVADCGeneral { get; set; }
        double TotalCheltuieliFaraTVADCGeneral { get; set; }    
        double CursValutarEURDCGeneral { get; set; }
        int IdPersoanaVerificareDCGeneral { get; set; }
        Angajati_Detalii PersoanaVerificareDCGeneral { get; set; }
        DateTime DataVerificareDecont { get; set; }
        int IdNrAutoDecont { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoDecont { get; set; }
        int IdPersoanaDecont { get; set; }
        Firme_Persoane_Contact PersoanaDecont { get; set; }
        int IdKmPlecareDecont { get; set; }
        int IdKmSosireDecont { get; set; }
        int TipConsumDecont { get; set; }
        double RestRezervorSosireCalculatDecont { get; set; }
        double RestRezervorSosireRealDecont { get; set; }
        double RestRezervorPlecareRealDecont { get; set; }
        double TotalLitriAlimentatiDecont { get; set; }
        DateTime DataIntroduceriiDecont { get; set; }
        DateTime OraIntroduceriiDecont { get; set; }
        bool VerificatConsumuriGlobaleDCGeneral { get; set; }
        int KilomNejustificatiDCGeneral { get; set; }
        bool BalantaEmisaDCGeneral { get; set; }
        double LitriiNerecuperati { get; set; }
        int LitriConsumatiReali { get; set; }
    }
}
