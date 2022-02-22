using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inchidere_Avansuri_Persoane
    {
        int IdInchidereAvans { get; set; }
        int IdPersoanaAvans { get; set; }
        Firme_Persoane_Contact PersoanaAvans { get; set; }
        DateTime DataAvans { get; set; }
        double SumaAvans { get; set; }
        int IdValutaAvans { get; set; }
        Lista_Valute ValutaAvans { get; set; }
        DateTime DataDecontare { get; set; }
    }
}
