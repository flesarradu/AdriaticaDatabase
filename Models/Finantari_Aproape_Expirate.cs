using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Finantari_Aproape_Expirate
    {
        String FirmaNume { get; set; }
        DateTime DataScadentaRataAltaFinantare { get; set; }
        String Explicatii { get; set; }
        int NrZile { get; set; }
        String NrContractAltaFinantare { get; set; }
    }
}
