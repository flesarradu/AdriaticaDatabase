using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inchidere_Sume_Decontate_Persoane
    {
        int IdInchidereAvans { get; set; }
        int IdPersoanaDecontare { get; set; }
        Firme_Persoane_Contact PersoaneDecontare { get; set; }
        DateTime DataDecontare { get; set; }
        double SumaDecontare { get; set; }
        int IdValutaDecontare { get; set; }
        Lista_Valute ValutaDecontare { get; set; }

    }
}
