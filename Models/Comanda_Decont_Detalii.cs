using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Comanda_Decont_Detalii
    {
        int IdComDecDet { get; set; }
        int IdDetaliiComDec { get; set; }
        Comanda_Decont DetaliiComDec { get; set; }
        int NrCrtComDecDet { get; set; }
        int IdDenumireOperatieComDecDet { get; set; }
        Denumire_Operatie DenumireOperatieComDecDet { get; set; }
        double BUC_KM_ORE_OperatieComDecDet { get; set; }
        double TarifDenumireOpComDecDet { get; set; }
        double ValoareDenumireOpComDecDet { get; set; }
        int IdDenumireMaterialComDecDet { get; set; }
        Lista_Produse DenumireMaterialComDecDet { get; set; }
        String NrBonComDecDet { get; set; }
        double BUC_KG_ComDecDet { get; set; }
        double PretUnitarComDecDet { get; set; }
        double ValoareComDecDet { get; set; }
        double AdaosComercialComDecDet { get; set; }
        String CodMaterialComDecDet { get; set; }
        int IdBonConsumDetalii { get; set; }
        Bon_De_Consum_Detalii BonConsumDetalii { set; get; }

    }
}
