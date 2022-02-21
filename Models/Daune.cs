using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Daune
    {
        int IdDaune { get; set; }
        int IdSofer { get; set; }
        Firme_Persoane_Contact Sofer { get; set; }
        int IdMasina { get; set; }
        Lista_NrAuto_Masini_Proprii Masina { get; set; }
        String Vinovat { get; set; }
        int NrInregistrare { get; set; }
        DateTime DataProducerii { get; set; }
        DateTime DataInregistrarii { get; set; }
        String DescriereDauna { get; set; }
        String LoculProducerii { get; set; }
        DateTime DataAnuntarii { get; set; }
        String ActeReferitoareLaDauna { get; set; }
        int PerioadaMasinaIndisponibila { get; set; }
        int ModSolutionare { get; set; }
        bool Recuperata { get; set; }
        String SocietateDeAsigurari { get; set; }
        String NrDosar { get; set; }
        DateTime DataDeschidereDosar { get; set; }
        String TipDocument1 { get; set; }
        String TipDocument2 { get; set; }
        String TipDocument3 { get; set; }
        DateTime DataTipDocument1 { get; set; }
        DateTime DataTipDocument2 { get; set; }
        DateTime DataTipDocument3 { get; set; }
        String FacturaDeviz1 { get; set; }
        String FacturaDeviz2 { get; set; }
        String FacturaDeviz3 { get; set; }
        double ValoareFacturaDeviz1 { get; set; }
        double ValoareFacturaDeviz2 { get; set; }
        double ValoareFacturaDeviz3 { get; set; }
        double TotalValoareDauna { get; set; }
        DateTime DataInchidereDosar { get; set; }
        DateTime DataRecuperare { get; set; }
        String NumePersoanaFirma { get; set; }
        String NrPolitaAsigurare { get; set; }
        String TipDauna { get; set; }
        String Ruta { get; set; }
    }
}
