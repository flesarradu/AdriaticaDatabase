using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Rezerve_Reevaluare_MF
    {
        int IdMFReevaluare { get; set; }
        DateTime DataInceputReevaluare { get; set; }
        DateTime DataSfarsitReevaluare { get; set; }
        double ValoareLunaraReevaluare { get; set; }
        double TotalReevaluare { get; set; }
        int IdContDebitReevaluare { get; set; }
        Lista_Conturi ContDebitReevaluare { get; set; }
        int IdContCreditReevaluare { get; set; }
        Lista_Conturi ContCreditReevaluare { get; set; }
    }
}
