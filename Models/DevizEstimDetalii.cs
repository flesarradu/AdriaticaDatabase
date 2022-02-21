using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class DevizEstimDetalii
    {
        int IdDevizEstimDetalii { get; set; }
        int IdDevizEstim { get; set; }
        DevizEstim DevizEstim { get; set; }
        String IdDevizDetaliiProdus { get; set; }
        String DevizDetaliiCode { get; set; }
        double DevizDetaliiPret { get; set; }
        double DevizDetaliiCantitate { get; set; }
        double DevizDetaliiValoare { get; set; }
        int DevizDetaliiNrCrt { get; set; }
        String IdDevizDetaliiDenumire { get; set; }
        double DevizDetaliiBucDenumire { get; set; }
        double DevizDetaliiTarifDenumire { get; set; }
        double DevizDetaliiValoareDenumire { get; set; }

    }
}
