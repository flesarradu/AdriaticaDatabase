using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Partide_Carnete_TIR
    {
        int IdPartidaCarnet { get; set; }
        Partide PartidaCarnet { get; set; }
        int IdSerieCarnetTir { get; set; }
        Carnete_TIR SerieCarnetTir { get; set; }
    }
}
