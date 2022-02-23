using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Plati
    {
        int IdPlati { get; set; }
        int IdFacturaPlati { get; set; }
        Facturi_Carausi FacturaPlati { get; set; }
        DateTime DataPlati { get; set; }
        double SumaPlati { get; set; }
        int IdMonedaPlati { get; set; }
        Lista_Valute MonedaPlati { get; set; }
        int IdModPlati { get; set; }
        Lista_Modalitati_Incasari_Plati ModPlati { get; set; }
        String NrDocumentPlati { get; set; }
        int IdContBanca { get; set; }
        Firme_Proprii_Conturi ContBanca { get; set; }
        double CursValPlati { get; set; }
        int Modul { get; set; }
        int IdModul { get; set; }
        int IdModulMa { get; set; }
        DateTime DataNotaContabila { get; set; }
        double SumaPlatiLEI { get; set; }
        int IdContDebitPlati { get; set; }
        Lista_Conturi ContDebitPlati { get; set; }
        int  IdContCreditPlati { get; set; }
        Lista_Conturi ContCreditPlati { get; set; }
        double DiferentaValutara { get; set; }
        double SumaPlatiEUR { get; set; }
        double SumaPlatiLeiVechi { get; set; }
        double SumaPlatitaInValutaFacturii { get; set; }
        double CursValFactPlati { get; set; }
        double SumaRonLaDataFacturii { get; set; }
        double SumaRonLaDataIncasarii { get; set; }
    }
}
