using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Balanta_Inceput_De_An_Analitica
    {
        int IdBalantaAnterioara { get; set; }
        int IdContBalanta { get; set; }
        Lista_Conturi ContBalanta { get; set; }
        double SoldFinalDebitor { get; set; }
        double SoldFinalCreditor { get; set; }
        int IdFirma { get; set; }
        Firme Firma { get; set; }
        int IdPersoana { get; set; }
        Firme_Persoane_Contact Persoana { get; set; }
        int Anul { get; set; }
        bool Introdus { get; set; }
        double SumaValutaDebit { get; set; }
        double SumaValutaCredit { get; set; }
        int IdValuta { get; set; }
        Lista_Valute Valuta { get; set; }
    }
}
