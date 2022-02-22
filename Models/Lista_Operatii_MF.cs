using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Operatii_MF
    {
        int IdOperatieMF { get; set; }
        int IdMF { get; set; }
        String OperatiaMF { get; set; }
        double DebitMF { get; set; }
        double CreditMF { get; set; }
        double SoldMF { get; set; }
        DateTime DataOperatie { get; set; }
        double ValoareLunaraReevaluataObiectMF { get; set; }
        String DocumentMF { get; set; }
        double SoldMFVechi { get; set; }
    }
}
