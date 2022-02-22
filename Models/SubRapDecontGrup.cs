using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class SubRapDecontGrup
    {
        double SumaValuta { get; set; }
        int IdMoneda { get; set; }
        Lista_Valute Moneda { get; set; }
    }
}
