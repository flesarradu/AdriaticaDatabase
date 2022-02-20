using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Schimb_Valutar
    {
        int IdSchimbVal { get; set; }
        DateTime DataCurentaSch { get; set; }
        double SumaSchDebit { get; set; }
        double SumaSchCredit { get; set; }
        double DiferentaSch { get; set; }
        int IdMonedaDebitSch { get; set; }
        Lista_Valute MonedaDebitSch { get; set; }
        int IdMonedaCreditSch { get; set; }
        Lista_Valute MonedaCreditSch { get; set; }
        int IdContDebitSch { get; set; }
        Lista_Conturi ContDebitSch { get; set; }
        int IdContCreditSch { get; set; }
        Lista_Conturi ContCreditSch { get; set; }
        String ExtrasSchimb { get; set; }
        bool ExportatSchimb { get; set; }
        bool SchimbVal_Virament { get; set; }
    }
}
