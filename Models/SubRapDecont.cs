using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class SubRapDecont
    {
        bool Numerar { get; set; }
        double Suma { get; set; }
        int IdMoneda { get; set; }
        Lista_Valute Moneda { get; set; }
    }
}
