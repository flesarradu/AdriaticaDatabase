using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class KmMasiniNeproductiveFAZ
    {
        int IdFAZNeproductive { get; set; }
        int IdNrAutoFAZNeproductive { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoFAZNeproductive { get; set; }
        int KmPlecareNeproductiveFAZ { get; set; }
        int KmSosireNeproductiveFAZ { get; set; }
        String NrFoaieParcursNeproductiveFAZ { get; set; } 
        DateTime DataFoiiParcursNeproductiveFAZ { get; set; }
        double TimpExploatareNeproductiveFAZ { get; set; }
        DateTime DataPlecareNeproductiveFAZ { get; set; }
        DateTime DataSosireNeproductiveFAZ { get; set; }
        int IdSoferNeproductiveFAZ { get; set; }
        Firme_Persoane_Contact SoferNeproductive { get; set; }
        int UleiMotorNeproductiveFAZ { get; set; }
        double LitriConsumatiNeproductiveFAZ { get; set; }
        double ConsumMediuNeproductiveFAZ { get; set; }
        int RestRezervorNeproductiveFAZ { get; set; }
        String RutaNeproductiveFAZ { get; set; }
        String ObservatiiNeproductiveFAZ { get; set; }
        int RestRezPlecareFAZ { get; set; }
        int RestRezSosireFAZ { get; set; }
        int AlimentareCombustibilNeproductiveFAZ { get; set; }
        double ConsumNormatNeproductiveFAZ { get; set; }
        int KmParcursiRezultatNepFAZ { get; set; }
        int ConsumEfectivRezultatNepFAZ { get; set; }
        int ConsumNormatRezultatNepFAZ { get; set; }
        int DiferenteCombustibilNepFAZ { get; set; }
    }
}
