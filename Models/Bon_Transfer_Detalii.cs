using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Bon_Transfer_Detalii
    {
        int IdBonServiciu { get; set; }
        int IdBonDetalii { get; set; }
        Bon_Transfer BonDetalii { get; set; }
        int NrCrtBonDetalii { get; set; }
        int IdProdusBonDet { get; set; }
        Lista_Produse ProdusBonDet { get; set; }
        String CodProdusBonDet { get; set; }
        double CantBonDet { get; set; }
        double PretBonDet { get; set; }
        double ValBonDet { get; set; }
        double TotalFactBonDet { get; set; }
        int IdUMBonDet { get; set; }
        Lista_Varia UMBonDet { get; set; }
        double PretVanzareBonDet { get; set; }
        double ValoareVanzareBonDet { get; set; }
        int IdGestiuneaDeTransfer { get; set; }
        Lista_Gestiuni GestiuneaDeTransfer { get; set; }
        int IdGestiuneaCurenta { get; set; }
        Lista_Gestiuni GestiuneaCurenta { get; set; }
        double StocAjutorBonTransf { get; set; }
        DateTime DataIesireProdusBonTransf { get; set; }
        int IdContDebitBonTransfer { get; set; }
        Lista_Conturi ContDebitBonTransder { get; set; }
        int IdCreditBonTransfer { get; set; }
        Lista_Conturi CreditBonTransfer { get; set; }

    }
}
