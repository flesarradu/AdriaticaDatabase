using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Oferta_Marfa_Detalii_Incarcare
    {
        int IdDetaliiIncarcare { get; set; }
        int IdOfertaMarfaDetaliiIncarcare { get; set; }
        Oferta_Marfa OfertaMarfaDetaliiIncarcare { get; set; }
        int IdNaturaMarfaDetaliiIncarcare { get; set; }
        Lista_Natura_Marfa NaturaMarfaDetaliiIncarcare { get; set; }
        int IdOrasIncarcareDetaliiIncarcare { get; set; }
        Lista_Orase OrasIncarcareDetaliiIncarcare { get; set; }
        DateTime DataIncarcariiDetaliiIncarcare { get; set; }
        int IdTaraIncarcareDetaliiIncarcare { get; set; }
        Lista_Tari TaraIncarcareDetaliiIncarcare { get; set; }
        int IdValutaValoareMarfaDetaliiIncarcare { get; set; }
        Lista_Valute ValutaValoareMarfaDetaliiIncarcare { get; set; }
        double ValoareMarfaDetaliiIncarcare { get; set; }
        int GreutateDetaliiIncarcare { get; set; }
        int VolumDetaliiIncarcare { get; set; }
        int LungimeDetaliiIncarcare { get; set; }
        int LatimeDetaliiIncarcare { get; set; }
        int InaltimeDetaliiIncarcare { get; set; }
        String AdresaIncarcareDetaliiIncarcare { get; set; }
        String PerContIncarcareDetaliiIncarcare { get; set; }
        String TelPersContIncarcareDetaliiIncarcare { get; set; }
        String ComisionarVamalIncarcareDetaliiIncarcare { get; set; }
        int OrdineIncarcare { get; set; }
        String ObservatiiIncarcare { get; set; }
        String VamaIncarcare { get; set; }
        int ColeteDetaliiIncarcare { get; set; }
        bool PrintabilaIncarcare { get; set; }
        int IdFirmaDetaliiIncarcare { get; set; }
        Firme FirmaDetaliiIncarcare { get; set; }
    }
}
