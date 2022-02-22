using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Incasari
    {
        int IdIncasari { get; set; }
        int IdFacturaIncasari { get; set; }
        DateTime DataIncasari { get; set; }
        double  SumaIncasari { get; set; }
        int IdMonedaIncasari { get; set; }
        Lista_Valute MonedaIncasari { get; set; }
        int IdModIncasari { get; set; }
        Lista_Modalitati_Incasari_Plati ModIncasare { get; set; }
        String NrDocumentIncasari { get; set; }
        double CursValIncasari { get; set; }
        int IdContBanca { get; set; }
        Firme_Proprii_Conturi ContBanca { get; set; }
        int Modul { get; set; }
        int IdModul { get; set; }
        int IdModulMa { get; set; }
        double CursValFactIncasari { get; set; }
        DateTime DataNotaContabila { get; set; }
        double SumaIncasariLEI { get; set; }
        int IdContDebitIncasari { get; set; }
        Lista_Conturi ContDebitIncasari { get; set; }
        int IdContCreditIncasari { get; set; }
        Lista_Conturi ContCreditIncasari { get; set; }
        int IdCategorieIntrareIesire { get; set; }
        Lista_Categorie_Banca CategorieIntrareIesire { get; set; }
        double DiferentaValutara { get; set; }
        double SumaIncasariEUR { get; set; }
        double SumaIncasariLeiVechi { get; set; }
        double SumaIncasataInValutaFacturii { get; set; }
        double SumaInRonLaDataFacturii { get; set; }
        double SumaInRonLaDataIncasarii { get; set; }
    }
}
