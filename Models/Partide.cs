using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Partide
    {
        int IdPartida { get; set; }
        int IdOfertaMarfaPartida { get; set; }
        Oferta_Marfa OfertaMarfaPartida { get; set; }
        int IdOfertaTransportPartida { get; set; }
        Oferta_Transport OfertaTransportPartida { get; set; }
        int IdCursaPartida { get; set; }
        Curse CursaPartida { get; set; }
        String CodPartida { get; set; }
        DateTime DataConstituirePartida { get; set; }
        DateTime OraConstituierePartida { get; set; }
        bool RezolvataPartida { get; set; }
        bool AnulataPartida { get; set; }
        bool ProprieIntermedPartida { get; set; }
        DateTime DataAnularePartida { get; set; }
        DateTime OraAnularePartida { get; set; }
        String ObservatiiPartida { get; set; }
        bool ExternaInternaPartida { get; set; }
        double TarifFClientPartida { get; set; }
        int IdMonedaRefTarifClientPartida { get; set; }
        Lista_Valute MonedaRefTarifClientPartida { get; set; }
        double SumaRefTarifFClientPartida { get; set; }
        double DiscountTarifPartida { get; set; }
        String ObsTFClientPartida { get; set; }
        int IdNrAuto1PropriiPartida { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto1PropriiPartida { get; set; }
        int IdNrAutor2PropriiPartida { get; set; }
        Lista_NrAuto_Masini_Proprii NrAuto2PropriiPartida { get; set; }
        String NrAutoIntermedPartida { get; set; }
        int IdSofer1PropriiPartida { get; set; }
        Firme_Persoane_Contact Sofer1PropriiPartida { get; set; }
        int IdSofer2PropriiPartida { get; set; }
        Firme_Persoane_Contact Sofer2PropriiPartida { get; set; }
        int IdRegim { get; set; }
        TurRetur Regim { get; set; }
        double RestIncasarePartida { get; set; }
        double MonRefRestIncasarePartida { get; set; }
        bool RestIncasareTrPartida { get; set; }
        bool FacturaPartida { get; set; }
        String SoferIntermedieriiPartida { get; set; }
        String NrTelSoferPartida { get; set; }
        DateTime DataTurReturPartida { get; set; }
        String NrComandaClientPartida { get; set; }
        bool IncheiatPartida { get; set; }
    }
}
