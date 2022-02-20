using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdriaticaDatabase.Models
{
    public class Bon_De_Consum_Detalii
    {
        int IdBonConsDet { get; set; }
        int IdConsumDet { get; set; }
        Bon_De_Consum ConsumDet { get; set; }
        int NrCrtBonConsDet { get; set; }
        String CodProdusBonConsDet { get; set; }
        int IdDenumireProdusBonConsDet { get; set; }
        Lista_Produse DenumireProdusBonConsDet { get; set; }
        double CantNecesaraBonConsDet { get; set; }
        int IdUMBonConsDet { get; set; }
        Lista_Varia UMBonConsDet { get; set; }
        double CantEliberataBonConsDet { get; set; }
        double PretUnitarBonConsDet { get; set; }
        double ValoareBonConsDet { get; set; }
        int BrNIRIntrareBonConsDet { get; set; }
        bool ComandaEmisaBonCons { get; set; }
        double AdaosComercialBonCons { get; set; }
        double PretUnitarCuAd { get; set; }
        double ValCuAdaosCom { get; set; }
        double PretUnitarCuAdCuTVA { get; set; }
        double ValCuAdaosComCuTVA { get; set; }
        bool ProdusFacturatVanzare { get; set; }
        int IdContDebitBonCons { get; set; }
        Lista_Conturi ContDebitBonCons { get; set; }
        int IdContCreditBonCons { get; set; }
        Lista_Conturi ContCreditBonCons { get; set; }
        double StocAjutorBonCons { get; set; }
        DateTime DataIesireProdusBonCons { get; set; }
        int IdGestiuneBonDet { get; set; }
        Lista_Gestiuni GestiuneBonDet { get; set; }
    }
}
