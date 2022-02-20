using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Registru_Casa
    {
        int IdRegistruCasa { get; set; }
        DateTime DataRegistruCasa { set; get; }
        int ContulCasa { get; set; }
        String OPPADRegistruCasa { get; set; }
        double SoldInitialRegistruCasa { set; get; }
        double SoldFinalRegistruCasa { set; get; }
        int IdMoneda { get; set; }
        Lista_Valute Moneda { get; set; }
        double SoldInitialContabil { set; get; }
        double SoldFinalContabil { set; get; }
        bool Contabilitate { get; set; }
        bool VerificatCasa { get; set; }
        DateTime DataVerificarii { set; get; }
        DateTime DataDeblocarii { set; get; }
        bool BalantaEmisaCasa { get; set; }
        double SoldInitialContabilLei { set; get; }
        double SoldFinalContabilLei { set; get; }

    }
}
