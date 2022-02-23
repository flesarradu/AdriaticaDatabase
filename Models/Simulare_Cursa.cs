using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Simulare_Cursa
    {
        int IdSimulare { get; set; }
        DateTime DataSimulare { get; set; }
        int IdOrasDestinatieSimulare { get; set; }
        Lista_Orase OrasDestinatieSimulare { get; set; }
        String CodRutaSimulare { get; set; }
        String DetaliiRutaSimulare { get; set; }
        int NrKilometriiSimulare { get; set; }
        double DiurnaSoferSimulare { get; set; }
        double ConsumMediuSimulare { get; set; }
        double PretMediuPeLitruSimulare { get; set; }
        double ValoareLitriiConsSimulare { get; set; }
        double TotalCheltDirecteSimulare { get; set; }
        double TotalCheltIndirecteSimulare { get; set; }
        double TotalCheltDirIndirSimulare { get; set; }
        double CotatieClientSimulare { get; set;}
        double MarjaProfitSimulare { get; set; }
        double PrecalculTarifSimulare { get; set; }
        int IdValutaPrecalculTarifSimualare { get; set; }
        Lista_Valute ValutaPrecalculTarifSimulare { get; set; }
        int IdOrasPlecareSimulare { get; set; }
        Lista_Orase OrasPlecareSimulare { get; set; }
    }
}
