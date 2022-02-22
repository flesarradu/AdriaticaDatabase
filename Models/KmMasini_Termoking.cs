using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class KmMasini_Termoking
    {
        int IdKmMasiniTermoking { get; set; }
        int IdDecontCursaGeneralTermoking { get; set; }
        Decont_Cursa_General DecontCursaGeneralTermoking { set; get; }
        int IdNumarAutoTermoking { get; set; }
        Lista_NrAuto_Masini_Proprii NumarAutoTermoking { get; set; }
        int RestRezervorPlecareTermoking { get; set; }
        int LitriiAlimentatiTermoking { get; set; }
        int RestRezervorSosireTermoking { get; set; }
        double ConsumLitriiTermoking { get; set; }
        double TimpDeFunctionareTermoking { get; set; }
    }
}
