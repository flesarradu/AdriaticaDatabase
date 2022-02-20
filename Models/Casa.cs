using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Casa
    {
        int IdCasa { get; set; }
        int InchidereAvansCLink { get; set; }
        DateTime DataCurentaCasa { get; set; }
        int IntrareIesireCasa { get; set; }
        double SumaCasa { get; set; }
        int IdMonedaCasa { get; set; }
        Lista_Valute MonedaCasa { get; set; }
        double MonRefSumaCasa { get; set; }
        int IdCategorieIntrareIesireCasa { get; set; }
        Lista_Categorie_Casa CategorieIntrareIesireCasa { get; set; }
        int IdContCheltuieliCasa { get; set; }
        Lista_Conturi ContCheltuieliCasa { get; set; }
        int IdTipDocJustCasa { get; set; }
        Lista_Doc_Casa TipDocJustCasa { get; set; }
        String NrDocJustCasa { get; set;}
        DateTime DataEmitereDocJustCasa { get; set;}
        int IdTipDocPlataIncasareCasa { get; set; }
        Lista_Doc_Casa TipDocPlataIncasareCasa { get; set; } 
        String NrDocPlataIncasareCasa { get; set;}
        DateTime DataDocPlataIncasare { get; set; }
        int IdTipDocCasierieCasa { get; set; }
        Lista_Varia TipDocCasierieCasa { get; set;}
        String NrDocCasierieCasa { get; set;}
        DateTime DataDocCasierieCasa { get; set;}
        String ExplicatiiOperatiuneCasa { get; set; }
        int IdPersoanaCasa { get; set; }
        Firme_Persoane_Contact PersoanaCasa { get; set;}
        bool AnulareCasa { get; set; }
        int IdContDebitCasa { get; set; }
        Lista_Conturi ContDebitCasa { get; set;}
        int IdContCreditCasa { get; set; }
        Lista_Conturi ContCreditCasa { get; set; }
        bool IncasareCasa { get; set;}
        int IdRegistruCasaMa { get; set; }
        Registru_Casa RegistruCasaMa { get; set;}
        bool Valid { get; set; }
        int IdFirmaCl { get; set; }
        Firme FirmaCl { get; set; }
        int IdFirmaFz { get; set; }
        Firme FirmeFz { get; set; }
        bool Contabilitate { get; set; }
        bool Creditare { get; set; }
        DateTime DataIntroduceriiCasa { get; set; }
        DateTime OraIntroduceriiCasa { get; set; }
        bool InJurnalDeCumparariCasa { get; set; }
        DateTime DataAvansuluiCasa { get; set; }
        double SumaInLei { get; set; }
        int IdCursa { get; set; }
        Id_Curse Cursa { get; set; }
        int TVACasa { get; set; }
        double ValoareFaraTVACasa { get; set; }
        double ValoareTVACasa { get; set; }
        int IdTipServiciuCasa { get; set; }
        int IdSchimbVal { get; set; }
        Schimb_Valutar SchimbVal { get; set; }
        int IdTipTVAVanzariCasa { get; set; }
        Lista_Tip_TVA_Vanzari TipTVAVanzariCasa { get; set; }
        int IdTipTVACumparariCasa { get; set; }
        Lista_Tip_TVA_Cumparari TipTVACumparariCasa { get; set; }


    }
}
