using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Decont_Litrii_Recuperati
    {
        int IdRecuperare { get; set; }
        int IdDecont { get; set; }
        Id_Decont_Cursa Decont { get; set; }
        int IdCursa { get; set; }
        Curse Cursa { get; set; }
        DateTime DataRecuperarii { get; set; }
        int LitriiRecuperati { get; set; }
        int IdSofer { get; set; }
        int LitriiDeRecuperat { get; set; }
        int LitriiNerecuperati { get; set; }
    }
}
