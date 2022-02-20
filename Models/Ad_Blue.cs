using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Ad_Blue
    {
        int IdDecontCursa { get; set; } 
        Curse cursa {get;set;}
        int IdNrAuto { get; set; }
        Lista_NrAuto_Masini_Proprii auto {get;set;}
        int KmParcursi { get; set; }
        int RestRezervorPlecare { get; set; }
        int LitriAlimentati { get; set; }
        double ConsumPerKM { get; set; }
        int LitriiConsumati { get; set; }
        int RestRezervorSosire { get; set; }

    }
}
