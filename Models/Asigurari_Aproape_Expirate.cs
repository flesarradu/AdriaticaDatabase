using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Asigurari_Aproape_Expirate
    {
        String NrAutoMasiniProprii { get; set; }
        DateTime DataScadentaRataAsigurare { get; set; }
        String Explicatii { get; set; }
        double NrZile { get; set; }
        String NrPoliteiAsigurare { get; set; }
        int IdAsiguratorAsigurare { get; set; }
        Firme AsiguratorAsigurare { get; set; }
    }
}
