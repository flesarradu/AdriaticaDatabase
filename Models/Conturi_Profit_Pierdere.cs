using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Conturi_Profit_Pierdere
    {
        int IdModul { get; set; }
        int IdContSintetic { get; set; }
        Lista_Conturi ContSintetic { set; get; }
        int IdContAnalitic { get; set; }
        Lista_Conturi ContAnalitic { set; get; }
        String Anul { get; set; }

    }
}
