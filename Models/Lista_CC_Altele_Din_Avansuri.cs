using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_CC_Altele_Din_Avansuri
    {
        int IdChelClasa { get; set; }
        String ChelClasa { get; set; }
        bool ExcludereClasa { get; set; }
        int IdContChelClasa { get; set; }
        Lista_Conturi ContChelCasa { get; set; }
        int IdContCreditClasa { get; set; }
        Lista_Conturi ContCreditClasa { get; set; }
        String ObservatiiChelClasa { get; set; }

    }
}
