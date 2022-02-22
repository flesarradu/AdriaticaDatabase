using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Grila_Consum_Masini_Proprii
    {
        int IdGrilaConsum { get; set; }
        int IdNrAutoGrilaConsum { set; get; }
        Lista_NrAuto_Masini_Proprii NrAutoGrilaConsum { set; get; }
        int IncarcaturaGrilaConsum { set; get; }
        double CoefCrestereGrilaConsum { set; get; }
        double ConsumPeGolGrilaConsum { set; get; }
    }
}
