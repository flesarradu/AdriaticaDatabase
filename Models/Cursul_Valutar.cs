using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Cursul_Valutar
    {
        int IdCursValutar { get; set; }
        int IdValutaCurs { get; set; }
        Lista_Valute ValutaCurs { get; set; }
        DateTime DataCursValutar { get; set; }
        double CursValutar { get; set; }
    }
}
