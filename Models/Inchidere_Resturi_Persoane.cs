using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inchidere_Resturi_Persoane
    {
        int IdInchidereAvans { get; set; }
        int IdPersoanaRest { get; set; }
        Firme_Persoane_Contact PersoanaRest { get; set; }
        DateTime DataRest { get; set; }
        double SumaRest { get; set; }
        int IdValutaRest { get; set; }
        Lista_Valute ValutaRest { get; set; }
        DateTime DataAvans { get; set; }
    }
}
