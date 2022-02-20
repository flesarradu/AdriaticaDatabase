using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_NrAuto_Masini_Proprii
    {
        int IdNrAutoMasiniProprii { get; set; }
        String NrAutoMasiniProprii { get; set; }
        bool AnulareNrAutoMasiniProprii { get; set; }
        bool NrAutoExport { get; set; }
        bool TertiMasiniProprii { get; set; }
        int IdTransporturi { get; set; }
    }
}
