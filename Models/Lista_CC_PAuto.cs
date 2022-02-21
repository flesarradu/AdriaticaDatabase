using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_CC_PAuto
    {
        int IdCPAuto { get; set; }
        String CPAutoCheltuiala { get; set; }
        bool CPAutoExcludere { get; set; }
        int IdContCP { get; set; }
        Lista_Conturi ContCP { get; set; }
        String ObservatiiCP { get; set; }
        bool ClasaRegieCP { get; set; }

    }
}
