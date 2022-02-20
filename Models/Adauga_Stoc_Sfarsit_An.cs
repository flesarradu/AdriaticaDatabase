using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Adauga_Stoc_Sfarsit_An
    {
        int IdStocInitial { get; set; }
        int IdProdusStocInitial { get; set; }
        Lista_Produse ProdusStocInitial { get; set; }
        String DenumireGrupaProdAjutor { get; set; }
        String DenumireProdAjutor { get; set; }
        String CodProdusStocInitial { get; set; }
        int IdUMStocInitial { get; set; }
        Lista_Varia UMStocInitial { get; set; }
        double CantStocInitial { get; set; }
        double PretVanzareStocInitial { get; set; }
        double ValStocInitial { get; set; }
        double TVAPeUMStocInitial { get; set; }
        double TVATotalStocInitial { get; set; }
        double TotalFactStocInitial { get; set; }
        int IdContDebitStocInitial { get; set; }
        Lista_Conturi ContDebitStocInitial { get; set; } 
        int IdContCreditStocInitial { get; set; }
        Lista_Conturi ContCreditStocInitial { get; set; }
        DateTime DataIntrareProdusStocInitial { get; set; }
        bool ProdusAdaugatInStoc { get; set; }
        bool ProdusActInFM { get; set; }
        double PretIntrareStocInitial { get; set; }
        double ValoareIntrareFaraTVAStocInitial { get; set; }
        double ProcentAdaosComercial { get; set; }
        int IdGestiuneStocInitial { get; set; }
        Lista_Gestiuni GestiuneStocInitial { get; set; }

    }
}
