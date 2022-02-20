using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Produse
    {
        int IdProdus { get; set; }
        String DenumireProdus { get; set; }
        String CodProdus { get; set; }
        int IdContDebitProdus { get; set; }
        Lista_Conturi ContDebitProdus { get; set; }
        int IdContCreditProdus { get; set; }
        Lista_Conturi ContCreditProdus { get; set; }
        int IdContDebitBCProdus { get; set; }
        Lista_Conturi ContDebitBCProdus { get; set; }
        int IdContCreditBCProdus { get; set; }
        Lista_Conturi ContCreditBCProdus { get; set; }
        int TopProdus { get; set; }
        int IdListaProduse { get; set; }
        Lista_Grupe_Produse ListaProduse { get; set; }
        double PretVanzareProdus { get; set; }
        double AdaosComercialProdus { get; set; }

    }
}
