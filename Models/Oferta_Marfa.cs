using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Oferta_Marfa
    {
        int IdOfertaMarfa { get; set; }
        int IdFirmaOM { get; set; }
        Firme FirmaOM { get; set; }
        int IdPersoanaContactOM { get; set; }
        Firme_Persoane_Contact PersoanaContactOM { get; set; }
        int IdValutaCotatieOM { get; set; }
        Lista_Valute ValutaCotatieOM { get; set; }
        DateTime OraPrimiriiOM { get; set; }
        DateTime DataPrimiriiOM { get; set; }
        int TermenIncasareOM { get; set; }
        double CotatieOM { get; set; }
        bool RezolvataOM { get; set; }
        bool AnulataOM { get; set; }
        DateTime DataRezAnulOM { get; set; }
        DateTime OraRezAnulOM { get; set; }
        int IdDispecerOM { get; set; }
        Firme_Persoane_Contact DispecerOM { get; set; }
        String ObservatiiGeneraleOM { get; set; }
        int TarifExternInternOM { get; set; }
        double NrKmOM { get; set; }
        int IdTVATarifOM { get; set; }
        Lista_Cota_TVA TVATarifOM { get; set; }
        double TarifulOM { get; set; }
        int IdValutaTarifOM { get; set; }
        Lista_Valute ValutaTarifOM { get; set; }
        double CotatieCuTVAOM { get; set; }
        int IdPartidaOM { get; set; }
        Partide PartidaOM { get; set; }
        String RutaOM { get; set; }
        String RutaTara { get; set; }


    }
}
