using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Rulaje_Precedente_Conturi_Sintetice
    {
        int IdSoldPrecedent { get; set; }
        int IdContul { get; set; }
        Lista_Conturi Contul { get; set; }
        double SoldDebit { get; set; }
        double SoldCredit { get; set; }
        String Luna { get; set; }
        int Anula { get; set; }
    }
}
