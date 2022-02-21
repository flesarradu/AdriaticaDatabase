using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_CC_Decont_Cursa
    {
        int IdDCCheltuiala { get; set; }
        String DCCheltuiala { get; set; }
        bool DCExcludere { get; set; }
        int IDContCheltuiala { get; set; }
        Lista_Conturi ContCheltuiala { get; set; }
        String ObservatiiCheltuiala { get; set; }
        int IdContCredit { get; set; }
        Lista_Conturi ContCredit { get; set; }
    }
}
