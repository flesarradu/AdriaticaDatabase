using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Invoices
    {
        int IdInvoice { get; set; }
        int IdFurnizorInvoice { get; set; }
        Firme FurnizorInvoice { set; get; }
        int IdCumparatorInvoice { get; set; }
        Firme CumparatorInvoice { set; get; }
        int IdValutaInvoice { get; set; }
        Lista_Valute ValutaInvoice { set; get; }
        bool AnulataInvoice { get; set; }
        String NumarInvoice { get; set; }
        String YourRefInvoice { get; set; }
        String OurRefInvoice { get; set; }
        String DeliveryTermsInvoice { get; set; }
        DateTime DataInvoice { get; set; }
        String DepartureInvoice { get; set; }
        String ArrivalInvoice { get; set; }
        String CurrencyInvoice { get; set; }
        double TotalInvoice { get; set; }
        DateTime DataIesireInvoice { get; set; } 
        int TermenDeIncasareInvoice { get; set; }
        bool IncasataInvoice { get; set; }
        double RestIncasareInvoice { set; get; }
        int IdPersoanaIntocmireInvoice { get; set; }
        Firme_Persoane_Contact PersoanaIntocmireInvoice { get; set;}
        String ObservatiiInvoice { get; set; }
        bool RestTrIncasareInvoice { set; get; }
        DateTime DataIncasareIntegralaInvoice { get; set; }
        int PaymentInvoice { get; set; }
        String ImporterInvoice { get; set; }
        int IdModeOfPaymentInvoice { get; set; }
        Lista_Modalitati_Incasari_Plati ModeOfPaymentInvoice { get; set; }
        int IdContulInvoice { get; set; }
        Firme_Proprii_Conturi ContulInvoice { get; set; }

    }
}
