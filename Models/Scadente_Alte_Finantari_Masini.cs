using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Alte_Finantari_Masini
    {
        int IdFinantareMasina { get; set; }
        int IdFinantare { get; set; }
        int IdMasinaFinantare { get; set; }
        Lista_NrAuto_Masini_Proprii MasinaFinantare { get; set; }
        double ValoareMasina { get; set; }
        int IdValutaValoareMasina { get; set; }
        Lista_Valute ValutaValoareMasina { get; set; }
        double ValoareMasinaEur { get; set; }

    }
}
