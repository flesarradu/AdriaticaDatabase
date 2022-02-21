using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Conturi_Diferente_Curs_Valutar
    {
        int IdModul { get; set; }
        String Modul { get; set; }
        int IdContSintetic { get; set; }
        Lista_Conturi ContSintetic { get; set; }
        int IdContAnalitic { get; set; }
        Lista_Conturi ContAnalitic { get; set; }

    }
}
