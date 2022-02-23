using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Of_Marfa_Detalii_Salvate
    {
        int IdDetaliiSOM { get; set; }
        String ObservatiiSOM { get; set; }
        String TraseulNrIncasareSOM { get; set; }
        int IdFirmaSOM { get; set; }
        Firme FirmaSOM { get; set; }
    }
}
