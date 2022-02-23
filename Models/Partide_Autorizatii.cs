using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Partide_Autorizatii
    {
        int IdPartidaAutorizatie { get; set; }
        Partide PartidaAutorizatie { get; set; }
        int IdSerieAutorizatie { get; set; }
        Autorizatii SetieAutorizatie { get; set; }
    }
}
