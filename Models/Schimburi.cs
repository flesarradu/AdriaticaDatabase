using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Schimburi
    {
        int IdSchimburi { get; set; }
        int IdNrAutoSchimburi { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoSchimburi { get; set; }
        int IdClasaSchimburi { get; set; }
        Lista_CC_Subclasa_PAuto ClasaSchimburi { get; set; }
        int KmSchimbSchimburi { get; set; }
        int KmBordCalculSchimburi { get; set; }
        int KmAvertizareConsumuiri { get; set; }

    }
}
