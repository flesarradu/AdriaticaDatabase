using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Of_Marfa_Detalii_Inc_Salvate
    {
        int IdDetaliiIncS { get; set; }
        int IdOMDetaliiIncS { get; set; }
        Oferta_Marfa OMDetaliiIncS { get; set; }
        int IdOrasIncDetaliiS { get; set; }
        Lista_Orase OrasIncDetaliiS { get; set; }
        int IdTaraIncDetaliiS { get; set; }
        Lista_Tari TaraIncDetaliiS { get; set; }
        int IdValutaValoareMarfaDetaliiIncS { get; set; }
        Lista_Valute ValutaValoareMarfaDetaliiIncS { get; set; }
        int ValoareMarfaDetaliiIncs { get; set; }
        int GreutateDetaliiIncS { get; set; }
        int VolumDetaliiIncS { get; set; }
        int LungimeDetaliiIncS { get; set; }
        int LatimeDetaliiIncS { get; set; }
        int InaltimeDetaliiIncS { get; set; }
        String AdresaDetaliiIncS { get; set;}
        String PersContDetaliiIncS { get; set;}
        String ComisionarVamalDetaliiIncS { get; set;}
        String VamaDetaliiIncS { get; set;}
        String TelPersContactDetaliiIncsS { get; set; }
        int IdNaturaMarfaIncSOM { get; set; }
        Lista_Natura_Marfa NaturaMarfaIncSom { get; set; }
    }
}
