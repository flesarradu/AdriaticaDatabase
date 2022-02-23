using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Oferta_Marfa_Detalii_Descarcare
    {
        int IdDetaliiDescarcare { get; set; }
        int IdOfertaMarfaDesc { get; set; }
        Oferta_Marfa OfertaMarfaDesc { get; set; }
        int IdOfertaMarfaDetaliiDescarcare { get; set; }
        Oferta_Marfa OfertaDetaliiDescarcare { get; set; }
        int IdOrasDescarcareDetaliiDescarcare { get; set; }
        Lista_Orase OrasDescarcareDetaliiDescarcare { get; set; }
        DateTime DataDescarcareDetaliiDescarcare { get; set; }
        int IdTaraDescarcareDetaliiDescarcare { get; set; }
        Lista_Tari TaraDescarcareDetaliiDescarcare { get; set; }
        int IdValutaValoareMarfaDetaliiDescarcare { get; set; }
        Lista_Valute ValutaValoareMarfaDetaliiDescarcare { get; set; }
        double ValoareMarfaDetaliiDescarcare { get; set; }
        int GreutateDetaliiDescarcare { get; set; }
        int VolumDetaliiDescarcare { get; set; }
        int LungimeDetaliiDescarcare { get; set; }
        int LatimeDetaliiDescarcare { get; set; }
        int InaltimeDetaliiDescarcare { get; set; }
        String AdresaDescarcareDetaliiDescarcare { get; set; }
        String PerContDescarcareDetaliiDescarcare { get; set; }
        String ComisionarVamalDescarcareDetaliiDescarcare { get; set; }
        String VamaDescarcareOM { get; set; }
        String TelPersContactDetaliiDescarcare { get; set; }
        int ColeteDetaliiDescarcare { get; set; }
        int IdNaturaMarfaDetaliiDescarcare { get; set; }
        Lista_Natura_Marfa NaturaMarfaDetaliiDescarcare { get; set; }
        int OrdineDescarcare { get; set; }
        String ObservatiiDescarcare { get; set; }
        bool PrintabilaDescarcare { get; set; }
        int IdFirmaDetaliiDescarcare { get; set; }
        Firme FirmaDetaliiDescarcare { get; set; }
    }
}
