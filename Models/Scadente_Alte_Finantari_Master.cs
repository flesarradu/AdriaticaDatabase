using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Scadente_Alte_Finantari_Master
    {
        int IdFinantare { get; set; }
        String ObiectulAltaFinantare { set; get; }
        int IdTipAltaFinantare { set; get; }
        Lista_Tipuri_Finantari TipAltaFinantare { set; get; }
        int IdValutaAltaFinantare { set; get; }
        Lista_Valute ValutaAltaFinantare { set; get; }
        String NrContractAltaFinantare { set; get; }
        double ValoareTotalaContractAltaFinantare { set; get; }
        int IdFinantatorAltaFinantare { set; get; }
        Firme FinantatorAltaFinantare { set; get; }
        double DurataContractuluiAltaFinantare { set; get; }
        int IdTVAAltaFinantare { get; set;}
        Lista_Cota_TVA TVAAltaFinantare { set; get; }
        int IdPersoanaIntocmireAltaFinantare { set; get; }
        Firme_Persoane_Contact PersoanaIntocmireAltaFinantare { set; get; }
        DateTime DataIntroduceriiAltaFinantare { get; set; }
        DateTime OraIntroduceriiAltaFinantare { get; set; }
        DateTime DataIncheiereContractAltaFinantare { get; set;}
        int CreditSauLeasingAltaFinantare { set; get; }
        String NumarDinRegDatPrivate_AltaFinantare { get; set; }
        bool ContabilitateAltaFinantare { get; set; }
        double CursValutarContractAltaFinantare { get; set; }
    }
}
