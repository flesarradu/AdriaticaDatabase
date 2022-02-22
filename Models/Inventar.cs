using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Inventar
    {
        int IdInventar { get; set; }
        String CodStoc { get; set; }
        int IdDenumireProdus { get; set; }
        Lista_Produse DenumireProdus { set; get; }
        double PretProdus { get; set; }
        double CantitateScriptica { get; set; }
        double CantitateFaptica { get; set; }
        double DiferenteCantitate { get; set; }
        double DiferenteValorice { get; set; }
        double DiferenteCantitateNul { get; set; }
        double DiferenteValoriceNul { get; set; }
        double CantitateFapticaNul { get; set; }
    }
}
