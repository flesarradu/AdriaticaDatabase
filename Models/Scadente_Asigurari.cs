using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Asigurari
    {
        int IdRataAsigurare { get; set; }
        int IdAsigurareDetalii { get; set; }
        int IdNrAutoAsigurare { get; set; }
        Lista_NrAuto_Masini_Proprii NrAutoAsigurare { get; set; }
        double ValoareRataAsigurare { get; set; }
        int IdValutaAsigurare { get; set; }
        Lista_Valute ValutaAsigurare { get; set; }
        DateTime DataScadentaRataAsigurare { get; set; }
        String NrPoliteiAsigurare { get; set; }
        double ValoareTotalaPolitaAsigurare { get; set; }
        String NrRateiAsigurare { get; set; }
        bool PlatitaRataAsigurare { get; set; }
        DateTime DataPlatiiRataAsigurare { get; set; }
        bool RestEur { get; set; }
        bool NuInCashFlow { get; set; }
        int IdContDebitAsigurare { get; set; }
        Lista_Conturi ContDebitAsigurare { get; set; }
        int IdContCreditAsigurare { get; set; }
        Lista_Conturi ContCreditAsigurare { get; set; }
        double CursValutarRataAsigurare { get; set; }
        DateTime DataPoliteiRataAsigurare { get; set; }
        double TotalValoareRataAsigurareEUR { get; set; }
        bool RataFacturataAsigurare { get; set; }
        int IdFacturaAsigurare { get; set; }
        Id_Facturi_Primite FacturaAsigurare { get; set; }
        DateTime DataFacturiiAsigurare { get; set; }

    }
}
