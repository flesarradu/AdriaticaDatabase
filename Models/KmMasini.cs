using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class KmMasini
    {
        int IdKmMasini { get; set; }
        int IdDecontCursaGeneralLink { get; set; }
        Decont_Cursa_General DecontCursaGeneralLink { get; set; }
        int IdNumarAutoKM { get; set; }
        Lista_NrAuto_Masini_Proprii NumarAutoKM { get; set; }
        int RestRezervorPlecareDCGeneral { get; set; }
        int LitriiAlimentatiDCGeneral { get; set; }
        int KmGolDCGeneral { get; set; }
        int ConsumGolGeneral { get; set; }
        int ConsumPlinDCGeneral { get; set; }
        int KmInterniDCGeneral { get; set; }
        int KmGolInternDCGeneral { get; set; }
        int LitriiIesireDCGeneral { get; set; }
        int LitriiIncExtDCGeneral { get; set; }
        int LitriiIncIntDCGeneral { get; set; }
        int KmPlecare { get; set; }
        int KmSosire { get; set; }
        int IdLocPlecareDCGeneral { get; set; }
        Lista_Orase LocPlecareDCGeneral { get; set; }
        int IdLocSosireDCGeneral { get; set; }
        Lista_Orase LocSosireDCGeneral { get; set; }
        double IncarcaturaDCGeneral { get; set;}
        int IdTaraPlecareDCGeneral { get; set; }
        Lista_Tari TaraPlecareDCGeneral { get; set; }
        int IdTaraSosireDCGeneral { get; set; }
        Lista_Tari TaraSosireDCGeneral { get; set; }
        double CoeficientTaraTronsDCGenersl { get; set; }
        int RestRezervorSosireDCGeneral { get; set; }
        double LitriiConsumatiDCGeneral { get; set; }
        bool SelectatGlobalDCGeneral { get; set; }
        int LitriiIncalzireDCGeneral { get; set; }
        int KmSuplimentatiDCGenera { get; set; }

    }
}
