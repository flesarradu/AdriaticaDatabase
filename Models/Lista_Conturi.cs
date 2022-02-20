using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Lista_Conturi
    {
        int IdCont { get; set; }
        String Contul { get; set; }
        String DescriereCont { get; set; }
        bool AnulareCont { get; set; }
        bool SinteticCont { get; set; }
        int IdTipCont { get; set; }
        Lista_Tipuri_Conturi TipCont { get; set; }
        double SumaDebitSoldPrecedent { get; set; }
        double SumaCreditSoldPrecedent { get; set; }
        double SoldInValuta { get; set; }
        int IdValutaSold { get; set; }
        Lista_Valute ValutaSold { get; set; }
        int AnulSold { get; set; }
        bool ContExtraContabil { get; set; }
        int IdCentreDeCost { get; set; }
        Lista_Centre_De_Cost CentreDeCost { get; set; }
    }
}
