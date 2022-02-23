using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Alte_Finantari
    {
       int IdRataAltaFinantare { get; set; }
       int IdFinantareRata { get; set; }
       double RataAltaFinantare { get; set; }
       double DobandaAltaFinantare { get; set; }
       double ComisionAltaFinantare { get; set; }
        double ValoareRataAltaFinantare { get; set; }
        DateTime DataScadentaRataAltaFinantare { get; set; }
        String NrRateiAltaFinantare { get; set; }
        bool PlatitaRataAltaFinantare { get; set; }
        DateTime DataPlatiiRataAltaFinantare { get; set; }
        double RestEur { get; set; }
        double TVARataAltaFinantare { get; set; }
        double CursValutarRataAsigurare { get; set; }
        int IdContDebitRataAltaFinantare { get; set; }
        Lista_Conturi ContDebitRataAltaFinantare { get; set; }
        int IdContCreditRataAltaFinantare { get; set; }
        Lista_Conturi ContCreditRataAltaFinantare { get; set; }
        bool NuInCashFlowAltaFinantare { get; set; }
        bool NuInJurnalAltaFinantare { get; set; }
        double TotalValoareRataAltaFinantareEUR { get; set; }
        double AsigurareAltaFinantare { get; set; }
        double TVADobandaAltaFinantare { get; set; }
        int IdTVADobanda { get; set; }
        Lista_Cota_TVA TVADobanda { get; set; }
        bool RataFacturataAltaFinantare { get; set; }
        int IdFacturaAltaFinantare { get; set; }
        Id_Facturi_Primite FacturaAltaFinantare { get; set; }
        DateTime DataFacturiiAltaFinantare { get; set; }

    }
}
