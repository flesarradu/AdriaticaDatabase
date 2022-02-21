using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Decont_Cursa_Avansuri_Resturi
    {
        int IdDecontGeneral { get; set; }
        Decont_Cursa_General DecontGeneral { get; set; } 
        int IdCasa { get; set; }
        Casa Casa { get; set; }
        DateTime Data { get; set; }
        double Suma { get; set; }
        int IdValuta { get; set; }
        Lista_Valute Valuta { get; set; }
        bool DinCasa { get; set; }
    }
}
