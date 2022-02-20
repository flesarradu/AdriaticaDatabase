using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Banca
    {
        int IdOperatiuneBanca { get; set; }
        int IdNumeBanca { get; set; }
        Lista_Banci NumeBanca { get; set; }
        DateTime DataCurentaBanca { get; set; }
        double SumaBanca { get; set; }
        int IdMonedaBanca { get; set; }
        Lista_Valute MonedaBanca { get; set; }
        double MonRefSumaBanca { get; set; }
        int IdCategorieIntrareIesireBanca { get; set; }
        Lista_Categorie_Banca CategorieIntrareIesireBanca { get; set; }
        int IdContCheltBanca { get; set; }
        Lista_Conturi ContCheltBanca { get; set; }
        int IdTipDocJustBanca { get; set; }
        Lista_Doc_Banca TipDocJusBanca { get; set; }
        String NrDocJustBanca { get; set; }
        DateTime DataEmitereDocJustBanca { get; set; }
        int IdTipDocPlataIncasareBanca { get; set; }
        Lista_Doc_Banca TipDocPlataIncasareBanca { get; set; }
        String NrDocPlataIncasareBanca {get; set; }
        String NrOp { get; set; }
        DateTime DataDocPlataIncasareBanca { get; set; }
        DateTime DataEfectuarePlataIncasareBanca { get; set; }
        int IdContBanca { get; set; }
        Firme_Proprii_Conturi ContBanca { get; set; }
        String BeneficiarBanca { get; set; }
        int IdPersoanaBanca { get; set; }
        Firme_Persoane_Contact PersoanaBanca { get; set; }
        double ComisionBancar { get; set; }
        int IdMonedaComisionBancar { get; set; }
        Lista_Valute MonedaComisionBancar { get; set; }
        int IntrareIesireBanca { get; set; }
        String ExplicatiiOperatiuneBanca { get; set; }
        bool AnulareBanca { get; set; }
        int IdRegistruBancaMa { get; set; }
        Registru_Banca RegistruBanca { get; set; }
        int IdContDebitBanca { get; set; }
        Lista_Conturi ContDebitBanca { get; set; }  
        int IdContCreditBanca { get; set; }
        Lista_Conturi ContCreditBanca { get; set; }
        bool Valid { get; set; }
        int IdFirmaCl { get; set; }
        Firme FirmaCl { get; set; }
        int IdFirmaFz { get; set; }
        Firme FirmaFz { get; set; }
        DateTime DataIntroduceriiBanca { get; set; }
        DateTime OraIntroduceriiBanca { get; set; }
        double SumaInLei { get; set; }
        int TVABanca { get; set; }
        double ValoareFaraTVABanca { get; set; }
        double ValoareTVABanca { get; set; }
        bool InJurnalDeCumparariBanca { get; set; }
        bool Contabilitate { get; set; }
        double ComisionBancarLei { get; set; }
        int IdTipServiciuBanca { get; set; }
        int IdSchimbVal { get; set; }
        Schimb_Valutar SchimbVal { get; set; }
        int InchidereAvansCLink { get; set; }
        int IdCursa { get; set; }
        Id_Curse Cursa { get; set; }
        int IdTipTVABanca { get; set; }
        Lista_Tip_TVA_Cumparari TipTVABanca { get; set; } 

    }
}
