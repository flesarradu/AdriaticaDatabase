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
        //Cursa cursa {get;set;} -- doar dupa ce creezi obiectul Cursa
        int NrAuto { get; set; }
        //Auto auto {get;set;} -- la fel dupa ce e creata clasa respectiva
        int KmParcursi { get; set; }
        int RestRezervorPlecare { get; set; }
        int LitriAlimentati { get; set; }
        int ConsumPerKM { get; set; }
        int LitriiConsumati { get; set; }
        int RestRezervorSosire { get; set; }

    }
}
