using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inventar_Mecanic
    {
        int IdInventarMecanic { get; set; }
        int IdMecanicInventar { get; set; }
        Lista_NrAuto_Masini_Proprii MecanicInventar { get; set; }
        DateTime DataInventarMecanic { get; set; }
        int IdPersoanaInventarMecanic { get; set; }
        Firme_Persoane_Contact PersoanaInventarMecanic { get; set; }

    }
}
