using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Asigurari_Masini
    {
        int IdAsigurareMasina { get; set; }
        int IdAsigurare { get; set; }
        DateTime DataStartContract { get; set; }
        int IdMasinaAsigurare { get; set; }
        Lista_NrAuto_Masini_Proprii MasinaAsigurare { get; set; }
        double ValoareContractAsigurare { get; set; }
        int IdValutaValoareContractAsigurare { get; set; }
        Lista_Valute ValutaValoareContractAsigurare { get; set; }
        DateTime DataExpirareContract { get; set; }
        int DurataContractLuni { get; set; }
        double ValoareContractAsigurareEur { get; set; }
    }
}
