using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Balanta
    {
        int IdBalanta { get; set; }
        int IdContBalanta { get; set; }
        Lista_Conturi ContBalanta { get; set; }
        String DenumireCont { get; set; }
        double RulajInitialDebitor { get; set; }
        double RulajInitialCreditor { get; set; }
        double RulajPrecedentDebitor { get; set; }
        double RulajPrecedentCreditor { get; set; }
        double RulajLunarDebitor { get; set; }
        double RulajCumulatDebitor { get; set; }
        double RulajCumulatCreditor { get; set; }
        double SoldFinalDebitor { get; set; }
        double SoldFinalCreditor { get; set; }
        int IdFirma { get; set; }
        
        Firme Firma { get; set;}
        int IdPersoana { get; set; }
        Firme_Persoane_Contact Persoana { get; set; }
        String ContSintetic { get; set; }
    }
}
