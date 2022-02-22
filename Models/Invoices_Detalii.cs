using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Invoices_Detalii
    {
        int IdServiciuInvoice { get; set; }
        int IdInvoiceServ { get; set; }
        Invoices InvoiceServ { get; set; }
        String Serviciu { get; set; }
        String UMServ { get; set; }
        double CantitateServ { get; set; }
        double PretServ { get; set; }
        double ValoareServ { get; set; }
    }
}
