using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Oferta_Transport
    {
        int IdOfertaTransport { get; set; }
        int IdOfertaMarfaOT { get; set; }
        Oferta_Marfa OfertaMarfaOT { set; get; }
        int IdFirmaOT { get; set; }
        Firme FirmaOT { get; set; }
        int IdPersoanaContactOT { get; set; }
        Firme_Persoane_Contact PersoanaContactOT { set; get; }
        int IdValutaOT { get; set; }
        Lista_Valute ValutaOT { get; set; }
        double CotatieOT { get; set; }
        DateTime DataIncasariiOT { get; set; }
        bool ValabilOT { get; set; }
        bool AlesOT { get; set; }
        int TermenPlataOT { get; set; }
        int TarifExternInternOT { get; set; }
        int NrKmOT { get; set; }
        int IdTVATarifOT { get; set; }
        Lista_Cota_TVA TVATarifOT { set; get; }
        double TarifulOT { get; set; }
        int IDValutaTarifOT { get; set; }
        Lista_Valute ValutaTarifOT { set; get; }
        double CotatieCuTVAOT { get; set; }
        int IdPartidaOT { get; set; }
        Partide PartidaOT { get; set; }
    }
}
