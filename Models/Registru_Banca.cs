using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Registru_Banca
    {
        int IdRegistruBanca { get; set; }
        DateTime  DataRegistruBanca { get; set; }
        int IdContBanca { get; set; }
        Firme_Proprii_Conturi ContBanca { get; set; }
        double SoldInitialCont { get; set; }
        double SoldFinalCont { get; set; }
        bool VerificatBanca { get; set; }
        DateTime DataVerificarii { get; set; }
        DateTime DataDeblocarii { get; set; }
        bool BalantaEmisaBanca { get; set; }
        double SoldInitialContLei { get; set; }
        double SoldFinalContLei { get; set; }
    }
}
