using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class KmMasiniFAZ
    {
        int IdFAZ { get; set; }
        int IdDecontCursaGeneralFAZ { get; set; }
        Decont_Cursa_General DecontCursaGeneral { get; set; }
        int IdNrAutoFAZ { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoFAZ { get; set; }
        int KmPlecareFAZ { get; set; }
        int KmSosireFAZ { get; set; }
        String NrFoaieParcursFAZ { get; set; }
        DateTime DataFoiiParcursFAZ { get; set; }
        double TimpExploatareFAZ { get; set; }
        DateTime DataPlecareFAZ { get; set; }
        DateTime DataSosireFAZ { get; set; }
        int IdSoferFAZ { get; set; }
        Firme_Persoane_Contact SoferFAZ { get; set; }
        int UleiMotorFAZ { get; set; }
        double LitriConsumatiFAZ { get; set; }
        double ConsumMediuFAZ { get; set; }
        int RestRezervorFAz { get; set; }
        int OreFunctionareInstAuxFAZ { get; set; }
        int LitriiConsumatiInstAuxiliaraFAZ { get; set; }
        int LitriConsumatiMotorGolFAZ { get; set; }
        int LichidDeRacireFAZ { get; set; }

    }
}
