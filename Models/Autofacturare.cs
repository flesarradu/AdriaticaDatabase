using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Autofacturare
    {
        int IdAutofacturare { get; set; }
        String NrDocument { get; set; }
        int IdFirma { get; set; }
        Firme Firma { get; set; } 
        DateTime Data { get; set; }
        double BazaDeImpozitare { get; set; }
        double Valoare { get; set; }
        int IdValuta { get; set; }
        Lista_Valute Valuta { get; set; }
        double CursValutar { get; set; }
        double EchivalentLei { get; set; }
        int IdContDebit { get; set; }
        Lista_Conturi ContDebit { get; set; }
        int IdContCredit { get; set; }
        Lista_Conturi ContCredit { get; set; }
        int IdCotaTVA { get; set; }
        Lista_Cota_TVA CotaTVA { get; set; }
        int IdTipTVAVanzariAutofacturare { get; set; }
        Lista_Tip_TVA_Vanzari ListaTipTVAVanzariAutofacturare { get; set; }
        int IdTipTVACumparariAutofacturare { get; set; }
        Lista_Tip_TVA_Cumparari ListaTipTVACumparariAutofacturare { get; set; }
        int IdFactura { get; set; }
        Id_Facturi Factura { get; set; }



    }
}
