using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inventar_Pe_Masina
    {
        int IdInventar { get; set; }
        int IdMasinaInventar { get; set; }
        Lista_NrAuto_Masini_Proprii MasinaInventar { get; set; }
        DateTime DataInventar { get; set; }
        int IdPersoanaInventar { get; set; }
        Firme_Persoane_Contact PersoanaInventar { get; set; }

    }
}
