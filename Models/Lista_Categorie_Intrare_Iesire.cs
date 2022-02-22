using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Categorie_Intrare_Iesire
    {
        int IdCategorieIntrareIesire { get; set; }
        String CategorieIntrareIesire { get; set; }
        int IdContDebit { get; set; }
        Lista_Conturi ContDebit { get; set; }
        int IdContCredit { get; set; }
        Lista_Conturi ContCredit { get; set; }
        bool Anulare { get; set; }
        bool Intrare { get; set; }
    }
}
