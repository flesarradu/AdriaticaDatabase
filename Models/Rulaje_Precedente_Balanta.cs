using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Rulaje_Precedente_Balanta
    {
        int IdSoldPrecedent { get; set; }
        int IdContul { get; set; }
        Lista_Conturi Contul { get; set; }
        int IdFirma { get; set; }
        Firme Firma { get; set; }
        int IdPersoana { get; set; }
        Firme_Persoane_Contact Persoana { get; set; }
        double SoldDebit { get; set; }
        double SoldCredit { get; set; }
        int IdLuna { get; set; }
        Lista_Luni Luna { get; set; }
        int Anul { get; set; }
        double SoldDebitLeiVechi { get; set; }
        double SoldCreditLeiVechi { get; set; }
        double DiferentaLeiVechi { get; set; }
    }
}
