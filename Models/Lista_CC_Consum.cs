using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_CC_Consum
    {
        int IdClasaConsum { get; set; }
        String ClasaConsum { set; get; }
        bool Excludere { get; set; }
        int IdContChelConsum { get; set; }
        Lista_Conturi ContChelConsum { set; get; }
        String ObservatiiChelConsum { set; get; }
        bool RegieFirma { get; set; }

    }
}
