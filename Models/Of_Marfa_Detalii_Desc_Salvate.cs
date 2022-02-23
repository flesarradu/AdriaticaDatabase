using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    internal class Of_Marfa_Detalii_Desc_Salvate
    {
        int IdDetaliiDescS { get; set; }
        int IdOMDetaliiDescS { get; set; }
        Oferta_Marfa OMDetaliiDescS { get; set; }
        int IdOrasDescDetaliiS { get; set; }
        Lista_Orase OrasDescDetaliiS { get; set; }
        int IdTaraDescDetaliiS { get; set; }
        Lista_Tari TaraDescDetaliiS { get; set; }
        int IdValutaValoareMarfaDetaliiDescS { get; set; }
        Lista_Valute ValutaValoareMarfaDetaliiDescS { get; set; }
        int ValoareMarfaDetaliiDescs { get; set; }
        int GreutateDetaliiDescS { get; set; }
        int VolumDetaliiDescS { get; set; }
        int LungimeDetaliiDescS { get; set; }
        int LatimeDetaliiDescS { get; set; }
        int InaltimeDetaliiDescS { get; set; }
        String AdresaDetaliiDescS { get; set; }
        String PersContDetaliiDescS { get; set; }
        String ComisionarVamalDetaliiDescS { get; set; }
        String VamaDetaliiDescS { get; set; }
        String TelPersContactDetaliiDescsS { get; set; }
        int IdNaturaMarfaDescSOM { get; set; }
        Lista_Natura_Marfa NaturaMarfaDescSom { get; set; }
    }
}
