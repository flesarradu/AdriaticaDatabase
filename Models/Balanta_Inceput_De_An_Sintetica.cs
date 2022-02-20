using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Balanta_Inceput_De_An_Sintetica
    {
        int IdBalantaAnterioara { get; set; }
        int IdContBalanta { get; set; }
        Lista_Conturi ContBalanta { get; set; }
        double SoldFinalDebitor { get; set; }
        double SoldFinalCreditor { get; set; }
        int Anul { get; set; }
    }
}
