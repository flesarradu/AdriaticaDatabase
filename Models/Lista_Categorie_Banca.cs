using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Categorie_Banca
    {
        int IdCategorieBanca { get; set; }
        String CategorieNume { get; set; }
        int IdCont { get; set; }
        Lista_Conturi Cont { get; set; }
        int IdContDebit { get; set; }
        Lista_Conturi ContDebit { get; set; }
        int IdContCredit { get; set; }
        Lista_Conturi ContCredit { get; set; }
        bool Anulare { get; set; }
        bool Intrare { get; set; }
        int IdOld { get; set; }
    }
}
